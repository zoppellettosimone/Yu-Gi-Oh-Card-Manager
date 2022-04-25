using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOhCardManager
{
    public partial class Menu : Form
    {
        #region Field

        List<Dictionary<string, object>> apiResList = new List<Dictionary<string, object>>();

        static List<Dictionary<string, object>> mongoDbWishlist = new List<Dictionary<string, object>>();

        static List<Dictionary<string, object>> mongoDbMyDeck = new List<Dictionary<string, object>>();

        static List<Dictionary<string, object>> mongoDbSeeDeck = new List<Dictionary<string, object>>();

        string nameCollection = "";

        //Chiamata Api
        string apiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

        DirectoryInfo d = new DirectoryInfo("D:\\GitHubRep\\yugiohCardManager\\pics");

        #region Emoji

        string squareVoidEmoji = "◻";
        string squareDoubleEmoji = "❐";

        string penEmoji = "🖊";
        string deleteEmoji = "❌";

        #endregion Emoji

        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        #endregion Field

        #region Builder
        //Costruttore
        public Menu(string userName)
        {
            Stopwatch testCostruttore = new Stopwatch();

            testCostruttore.Restart();

            InitializeComponent();

            nameCollection = userName;

            UpdateApi();

            UpdateListWishlist();

            UpdateListMyDeck();

            UpdateListSeeDeck();

            testCostruttore.Stop();

            Console.WriteLine("---> Costr: " + testCostruttore.ElapsedMilliseconds);
        }
        #endregion Builder

        #region Move Form
        //Metodi per lo spostamento della schermata
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Metodo usato per il muovimento del Form
        private void headerCreditsLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (resizeButton.Text != squareVoidEmoji)
                {
                    resizeButton.Text = squareVoidEmoji;
                }
                else
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        #endregion Move Form

        #region Resize Form

        //Metodo per ridimensionare il Form
        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                resizeButton.Text = squareVoidEmoji;
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                resizeButton.Text = squareDoubleEmoji;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //Ridurre ad icona il Form
        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion Resize Form

        #region Update List

        //Aggiornamento Lista
        private void UpdateListWishlist()
        {

            if (checkConnection() == true)
            {
                //Se è connesso

                mongoDbWishlist = MongoDB.Client
                    .GetDatabase("yugiohCardDb")
                    .GetCollection<Dictionary<string, object>>(nameCollection + "Wishlist")
                   .Find(Builders<Dictionary<string, object>>.Filter.Empty)
                   .ToList();

                //connectionLabel.Text = "Connected";

                SeeListWishlist();
            }
            else
            {
                //Se non è connesso
                //connectionLabel.Text = "Not Connected";
            }

        }

        //Aggiornamento Lista
        private void UpdateListMyDeck()
        {

            if (checkConnection() == true)
            {
                //Se è connesso

                // PRENDERE I DATI DALLE TAB SU MONGODB
                
                mongoDbMyDeck = MongoDB.Client
                    .GetDatabase("yugiohCardDb")
                    .GetCollection<Dictionary<string, object>>(nameCollection + "MyDeck")
                   .Find(Builders<Dictionary<string, object>>.Filter.Empty)
                   .ToList();

                //connectionLabel.Text = "Connected";

                SeeListMyDeck();
            }
            else
            {
                //Se non è connesso
                //connectionLabel.Text = "Not Connected";
            }

        }

        //Aggiornamento Lista
        private void UpdateListSeeDeck()
        {

            if (checkConnection() == true)
            {
                //Se è connesso

                // PRENDERE I DATI DALLE TAB SU MONGODB
                
                mongoDbSeeDeck = MongoDB.Client
                    .GetDatabase("yugiohCardDb")
                    .GetCollection<Dictionary<string, object>>(nameCollection + "TestDeck1")
                   .Find(Builders<Dictionary<string, object>>.Filter.Empty)
                   .ToList();

                //connectionLabel.Text = "Connected";

                SeeListSeeDeck();
            }
            else
            {
                //Se non è connesso
                //connectionLabel.Text = "Not Connected";
            }

        }

        private void UpdateApi()
        {
            Stopwatch checkTime = new Stopwatch();

            //Stringa Json dalla chiamata Api
            string jsonString = "";

            checkTime.Start();
            //Chiamata Api
            Uri address = new Uri(apiUrl);
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
            request.Method = "GET";
            request.ContentType = "text/json";

            try
            {
                //Salvataggio su "jsonString" della risposta
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    jsonString = reader.ReadToEnd();
                }

                //Conversione da Json String a Json
                var allJsonContent = JObject.Parse(jsonString);

                //Estrazione dei dati
                apiResList = allJsonContent["data"].Select(s => new Dictionary<string, object> {
                            { "name", s["name"].ToString() },
                            { "type", s["type"].ToString()},
                            { "race", s["race"].ToString()},
                            { "desc", s["desc"].ToString()},
                            { "attribute", s.ToObject<JObject>().ContainsKey("attribute") == true ? s["attribute"].ToString() : "Null" },
                            { "atk", s.ToObject<JObject>().ContainsKey("atk") == true ? int.Parse(s["atk"].ToString()) : 0},
                            { "def", s.ToObject<JObject>().ContainsKey("def") == true ? int.Parse(s["def"].ToString()) : 0},
                            { "level", s.ToObject<JObject>().ContainsKey("level") == true ? int.Parse(s["level"].ToString()) : 0},
                            { "linkval", s.ToObject<JObject>().ContainsKey("linkval") == true ? int.Parse(s["linkval"].ToString()) : 0},
                            { "imageId", s["card_images"][0]["id"].ToString()},
                            { "price", s["card_prices"][0]["cardmarket_price"].ToString()}
                                })
                                .ToList();

                checkTime.Stop();

                SeeListSearchCard();

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        #endregion Update List

        #region Check Connection

        //Metodo per il controllo della connessione
        private bool checkConnection()
        {
            return MongoDB.IsConnected();
        }

        #endregion Check Connection

        #region DataGridView View

        //Scrivere una singola riga
        private DataGridViewRow DrawOneSearchCard(Dictionary<string, object> item)
        {
            DataGridViewRow row = (DataGridViewRow)searchCardDataGridView.Rows[0].Clone();

            /*

            var file = d.GetFiles(item["imageId"].ToString() +  ".jpg");

            if (file.Length == 1)
            {

                ((DataGridViewImageCell)row.Cells[0]).Value = Image.FromFile(file[0].FullName);

            }

            */

            row.Cells[0].Value = item["name"];

            row.Cells[1].Value = item["type"];

            row.Cells[2].Value = item["race"];

            row.Cells[3].Value = item["attribute"];

            if (int.Parse(item["level"].ToString()) > 0)
            {
                row.Cells[4].Value = item["level"];
            }
            else
            {
                row.Cells[4].Value = item["linkval"];
            }

            row.Cells[5].Value = item["atk"];

            row.Cells[6].Value = item["def"];

            row.Cells[7].Value = item["desc"];

            row.Cells[8].Value = item["price"];

            if(float.Parse(item["price"].ToString()) < 300)
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.White;
            }else if (float.Parse(item["price"].ToString()) >= 300 && float.Parse(item["price"].ToString()) < 500)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }else if(float.Parse(item["price"].ToString()) > 500)
            {
                row.DefaultCellStyle.BackColor = Color.IndianRed;
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            row.Cells[7].Style.WrapMode = DataGridViewTriState.True;

            return row;

        }

        private DataGridViewRow DrawOneWishlist(Dictionary<string, object> item)
        {

            var file = d.GetFiles(item["imageId"].ToString() + ".jpg");

            DataGridViewRow row = (DataGridViewRow)wishlistDataGridView.Rows[0].Clone();

            if (file.Length == 1)
            {

                ((DataGridViewImageCell)row.Cells[0]).Value = Image.FromFile(file[0].FullName);

            }

            row.Cells[1].Value = item["name"];

            row.Cells[2].Value = item["nrCopies"];

            row.Cells[3].Value = item["price"];

            if (float.Parse(item["price"].ToString()) < 300)
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (float.Parse(item["price"].ToString()) >= 300 && float.Parse(item["price"].ToString()) < 500)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (float.Parse(item["price"].ToString()) > 500)
            {
                row.DefaultCellStyle.BackColor = Color.IndianRed;
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            return row;

        }

        private DataGridViewRow DrawOneMyDeck(Dictionary<string, object> item)
        {
            DataGridViewRow row = (DataGridViewRow)myDeckDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item["name"];

            row.Cells[3].Value = item["price"];

            if (!item["price"].ToString().Equals("None"))
            {
                if (float.Parse(item["price"].ToString()) < 1500)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (float.Parse(item["price"].ToString()) >= 1500 && float.Parse(item["price"].ToString()) < 3000)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (float.Parse(item["price"].ToString()) > 3000)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            return row;

        }

        private DataGridViewRow DrawOneSeeDeck(Dictionary<string, object> item)
        {

            var file = d.GetFiles(item["imageId"].ToString() + ".jpg");

            DataGridViewRow row = (DataGridViewRow)seeDeckDataGridView.Rows[0].Clone();

            if (file.Length == 1)
            {

                ((DataGridViewImageCell)row.Cells[0]).Value = Image.FromFile(file[0].FullName);

            }

            row.Cells[1].Value = item["name"];

            row.Cells[2].Value = item["nrCopies"];

            row.Cells[3].Value = item["price"];

            if (float.Parse(item["price"].ToString()) < 300)
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (float.Parse(item["price"].ToString()) >= 300 && float.Parse(item["price"].ToString()) < 500)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (float.Parse(item["price"].ToString()) > 500)
            {
                row.DefaultCellStyle.BackColor = Color.IndianRed;
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            return row;

        }

        private void SeeListSearchCard()
        {

            searchCardDataGridView.Visible = false;

            searchCardDataGridView.AllowUserToAddRows = true;

            searchCardDataGridView.Rows.Clear();

            List<DataGridViewRow> listRow = new List<DataGridViewRow>();

            apiResList
                .Where(p => p["name"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["type"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["race"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["attribute"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["level"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["atk"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["def"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["desc"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower())
                || p["price"].ToString().ToLower().Contains(searchSearchCardTextBox.Text.ToLower()))
                .ToList()
                .ForEach(p => listRow.Add(DrawOneSearchCard(p)));

            searchCardDataGridView.Rows.AddRange(listRow.ToArray());

            searchCardDataGridView.AllowUserToAddRows = false;

            searchCardDataGridView.Visible = true;
        }

        private void SeeListWishlist()
        {

            wishlistDataGridView.Visible = false;

            wishlistDataGridView.AllowUserToAddRows = true;

            wishlistDataGridView.Rows.Clear();

            List<DataGridViewRow> listRow = new List<DataGridViewRow>();

            apiResList
                .Join(mongoDbWishlist, item1 => item1["name"].ToString().ToLower(), item2 => item2["name"].ToString().ToLower(), (item1, item2) => new Dictionary<string, object> {
                    { "name", item1["name"].ToString() },
                    { "nrCopies", item2["nrCopies"].ToString() },
                    { "price", item1["price"].ToString() },
                    { "imageId", item1["imageId"].ToString()}
                })
                .Where(p => p["name"].ToString().ToLower().Contains(""/*searchSearchCardTextBox.Text.ToLower()*/)
                || p["nrCopies"].ToString().ToLower().Contains(""/*searchSearchCardTextBox.Text.ToLower()*/)
                || p["price"].ToString().ToLower().Contains(""/*searchSearchCardTextBox.Text.ToLower()*/))
                .ToList()
                .ForEach(p => listRow.Add(DrawOneWishlist(p)));

            wishlistDataGridView.Rows.AddRange(listRow.ToArray());

            wishlistDataGridView.AllowUserToAddRows = false;

            wishlistDataGridView.Visible = true;
        }

        private void SeeListMyDeck()
        {

            myDeckDataGridView.Visible = false;

            myDeckDataGridView.AllowUserToAddRows = true;

            myDeckDataGridView.Rows.Clear();

            List<DataGridViewRow> listRow = new List<DataGridViewRow>();

            mongoDbMyDeck.ForEach(p => listRow.Add(DrawOneMyDeck(p)));

            myDeckDataGridView.Rows.AddRange(listRow.ToArray());

            myDeckDataGridView.AllowUserToAddRows = false;

            myDeckDataGridView.Visible = true;
        }

        private void SeeListSeeDeck()
        {

            seeDeckDataGridView.Visible = false;

            seeDeckDataGridView.AllowUserToAddRows = true;

            seeDeckDataGridView.Rows.Clear();

            List<DataGridViewRow> listRow = new List<DataGridViewRow>();
            //listPasswordMongoDB
            //    .Where(s => s["site"].ToString().ToLower().Contains(searchTextBox.Text)
            //        || s["email"].ToString().ToLower().Contains(searchTextBox.Text)
            //        || s["password"].ToString().ToLower().Contains(searchTextBox.Text))
            //    .ToList()
            //    .ForEach(p => listRow.Add(DrawOneSearchCard(p)));

            apiResList
                .Join(mongoDbSeeDeck, item1 => item1["name"].ToString().ToLower(), item2 => item2["name"].ToString().ToLower(), (item1, item2) => new Dictionary<string, object> {
                    { "name", item1["name"].ToString() },
                    { "nrCopies", item2["nrCopies"].ToString() },
                    { "price", item1["price"].ToString() },
                    { "imageId", item1["imageId"].ToString()}
                })
                .Where(p => p["name"].ToString().ToLower().Contains(""/*searchSearchCardTextBox.Text.ToLower()*/)
                || p["nrCopies"].ToString().ToLower().Contains(""/*searchSearchCardTextBox.Text.ToLower()*/)
                || p["price"].ToString().ToLower().Contains(""/*searchSearchCardTextBox.Text.ToLower()*/))
                .ToList()
                .ForEach(p => listRow.Add(DrawOneSeeDeck(p)));

            seeDeckDataGridView.Rows.AddRange(listRow.ToArray());

            seeDeckDataGridView.AllowUserToAddRows = false;

            seeDeckDataGridView.Visible = true;
        }

        #endregion DataGridView View

        #region Search Filter

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            SeeListSearchCard();
        }

        #endregion Search Filter

        #region Update MongoDb

        public enum EAction
        {
            Insert = 10,
            Update = 20,
            Error = 30
        }

        /*
         * 
        //Metodo per l'aggiornamento e l'inserimento di nuove password
        private bool UpdateMongoDB(EAction action, string siteNew, string emailNew, string passwordNew,
            [Optional] string siteOld, [Optional] string emailOld, [Optional] string passwordOld)
        {
            
            try
            {
                //Controllo connessione MongoDB
                if (MongoDB.IsConnected())
                {
                    //In caso di inserimento
                    if (action == EAction.Insert)
                    {
                        //Nuovo Dict da inserire
                        Dictionary<string, object> dictToInsert = new Dictionary<string, object>();
                        dictToInsert.Add("site", siteNew);
                        dictToInsert.Add("email", emailNew);
                        dictToInsert.Add("password", passwordNew);

                        //InsertOne MongoDb
                        MongoDB.Client.GetDatabase("AllPassword")
                            .GetCollection<Dictionary<string, object>>(nameCollection + "Password")
                            .InsertOne(dictToInsert);

                        return true;
                    }
                    //In caso di Update
                    else if (action == EAction.Update)
                    {
                        //Filtro di ricerca
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("site", siteOld)
                             & Builders<Dictionary<string, object>>.Filter.Eq("email", emailOld)
                             & Builders<Dictionary<string, object>>.Filter.Eq("password", passwordOld);

                        //Update MongoDb
                        MongoDB.Client.GetDatabase("AllPassword").GetCollection<Dictionary<string, object>>(nameCollection + "Password")
                                .UpdateOne(searchFilter, Builders<Dictionary<string, object>>
                                .Update.Set("site", siteNew).Set("email", emailNew).Set("password", passwordNew));

                        return true;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);
                return false;
            }
        }

        //Bottone per inserire nuovi elementi
        private void insertButton_Click(object sender, EventArgs e)
        {
            //Apertura Form di Update
            UpdateForm uf = new UpdateForm();
            uf.ShowDialog();

            if (uf.DialogResult == DialogResult.OK)
            {
                //Aggiornamento Dati
                UpdateMongoDB(EAction.Insert,
                    uf.nameTextBox.Text,
                    uf.emailTextBox.Text,
                    uf.passwordTextBox.Text);
            }

            //Aggiornamento Lista
            UpdateList();
            
    }
        */

        #endregion Update MongoDB

    }
}
