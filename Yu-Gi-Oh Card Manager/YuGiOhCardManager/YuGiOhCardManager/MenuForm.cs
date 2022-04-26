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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuGiOhCardManager.Properties;

namespace YuGiOhCardManager
{
    public partial class MenuForm : Form
    {
        #region Field

        List<Dictionary<string, object>> apiResList = new List<Dictionary<string, object>>();

        static List<Dictionary<string, object>> mongoDbWishlist = new List<Dictionary<string, object>>();

        static List<Dictionary<string, object>> mongoDbMyDeck = new List<Dictionary<string, object>>();

        static List<Dictionary<string, object>> mongoDbSeeDeck = new List<Dictionary<string, object>>();

        string nameCollection = "";

        DirectoryInfo d = new DirectoryInfo("..\\..\\..\\..\\..\\pics");

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
        public MenuForm(string userName, List<Dictionary<string, object>> apiToPass)
        {
            //Stopwatch testCostruttore = new Stopwatch();

            //testCostruttore.Restart();

            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            apiResList = apiToPass;

            nameCollection = userName;

            //UpdateApi();
            SeeListSearchCard();

            UpdateListWishlist();

            UpdateListMyDeck();

            //UpdateListSeeDeck();

            //testCostruttore.Stop();

            //Console.WriteLine("---> Costr: " + testCostruttore.ElapsedMilliseconds);

            wf.Close();
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

                SeeListMyDeck();

                selectDeckComboBox.Items.Clear();
                selectDeckComboBox.Items.AddRange(mongoDbMyDeck.Select(s => new string(s["name"].ToString().ToCharArray())).ToArray());

                if (selectDeckComboBox.Items.Count > 0)
                {
                    selectDeckComboBox.SelectedIndex = 0;
                }


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
                    .GetCollection<Dictionary<string, object>>(nameCollection + selectDeckComboBox.Text.ToLower().Replace(" ", ""))
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

            row.Cells[8].Value = float.Parse(item["price"].ToString())/100;

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
            else
            {
                ((DataGridViewImageCell)row.Cells[0]).Value = Resources.unknownCard;
            }

            row.Cells[1].Value = item["name"];

            row.Cells[2].Value = item["type"];

            row.Cells[3].Value = item["nrCopies"];

            row.Cells[4].Value = float.Parse(item["price"].ToString())/100;

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

            row.Cells[5].Value = penEmoji;

            row.Cells[6].Value = deleteEmoji;

            row.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            row.Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            return row;

        }

        private DataGridViewRow DrawOneMyDeck(Dictionary<string, object> item)
        {
            DataGridViewRow row = (DataGridViewRow)myDeckDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item["name"];

            mongoDbSeeDeck = MongoDB.Client
                    .GetDatabase("yugiohCardDb")
                    .GetCollection<Dictionary<string, object>>(nameCollection + item["name"].ToString().Replace(" ", "").ToLower())
                   .Find(Builders<Dictionary<string, object>>.Filter.Empty)
                   .ToList();

            List<Dictionary<string, object>> card = mongoDbSeeDeck.Join(apiResList, item1 => item1["name"].ToString().ToLower(), item2 => item2["name"].ToString().ToLower(), (item1, item2) => new Dictionary<string, object> {
                    { "name", item1["name"].ToString() },
                    { "nrCopies", item1["nrCopies"].ToString() },
                    { "type", item2["type"].ToString() },
                    { "price", float.Parse(item2["price"].ToString())}
                }).ToList();

            int somMain = card.Where(p => !p["type"].ToString().ToLower().Contains("fusion")
            && !p["type"].ToString().ToLower().Contains("synchro")
            && !p["type"].ToString().ToLower().Contains("xyz")
            && !p["type"].ToString().ToLower().Contains("link")).Sum(p => int.Parse(p["nrCopies"].ToString()));

            int somExtra = card.Where(p => p["type"].ToString().ToLower().Contains("fusion")
            || p["type"].ToString().ToLower().Contains("synchro")
            || p["type"].ToString().ToLower().Contains("xyz")
            || p["type"].ToString().ToLower().Contains("link")).Sum(p => int.Parse(p["nrCopies"].ToString()));

            float price = card.Sum(p => float.Parse(p["price"].ToString()) * int.Parse(p["nrCopies"].ToString()));

            if (price < 3000)
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (price >= 3000 && price < 5000)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (price > 5000)
            {
                row.DefaultCellStyle.BackColor = Color.IndianRed;
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            row.Cells[1].Value = somMain;

            row.Cells[2].Value = somExtra;

            row.Cells[3].Value = price/100;

            row.Cells[4].Value = penEmoji;

            row.Cells[5].Value = deleteEmoji;

            row.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            row.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            else
            {
                ((DataGridViewImageCell)row.Cells[0]).Value = Resources.unknownCard;
            }

            row.Cells[1].Value = item["name"];

            row.Cells[2].Value = item["type"];

            row.Cells[3].Value = item["nrCopies"];

            row.Cells[4].Value = float.Parse(item["price"].ToString())/100;

            row.Cells[5].Value = penEmoji;

            row.Cells[6].Value = deleteEmoji;

            row.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            row.Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                    { "imageId", item1["imageId"].ToString()},
                    { "type", item1["type"].ToString() }
                })
                .Where(p => p["name"].ToString().ToLower().Contains(searchWishlistCardTextBox.Text)
                || p["nrCopies"].ToString().ToLower().Contains(searchWishlistCardTextBox.Text)
                || p["price"].ToString().ToLower().Contains(searchWishlistCardTextBox.Text))
                .OrderBy(p => p["type"].ToString())
                .ThenBy(p => p["name"].ToString())
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

            mongoDbMyDeck.Where(p => p["name"].ToString().ToLower().Replace(" ", "").Contains(searcMyDeckTextBox.Text.Replace(" ", ""))).ToList().ForEach(p => listRow.Add(DrawOneMyDeck(p)));

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

            apiResList
                .Join(mongoDbSeeDeck, item1 => item1["name"].ToString().ToLower(), item2 => item2["name"].ToString().ToLower(), (item1, item2) => new Dictionary<string, object> {
                    { "name", item1["name"].ToString() },
                    { "nrCopies", item2["nrCopies"].ToString() },
                    { "price", item1["price"].ToString() },
                    { "imageId", item1["imageId"].ToString()},
                    { "type", item1["type"].ToString() }

                })
                .Where(p => p["name"].ToString().ToLower().Replace(" ", "").Contains(searchSeeCardCardTextBox.Text.Replace(" ", ""))
                || p["nrCopies"].ToString().ToLower().Replace(" ", "").Contains(searchSeeCardCardTextBox.Text.Replace(" ", "")))
                .OrderBy(p => p["type"].ToString())
                .ThenBy(p => p["name"].ToString())
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
            timerSearchCard.Stop();

            timerSearchCard.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSearchCard.Stop();

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

        #endregion Update MongoDB

        private void insertWishlistButton_Click(object sender, EventArgs e)
        {
            AddCardForm acf = new AddCardForm(apiResList);
            acf.ShowDialog();

            if (acf.DialogResult == DialogResult.OK)
            {
                //Aggiornamento Dati
                UpdateWishlistMongoDB(EAction.Insert,
                    acf.cardTextBox.Text,
                    int.Parse(acf.copiesNumericUpDown.Value.ToString()));

                //Aggiornamento tab
                UpdateListWishlist();
            }
        }

        //Metodo per l'aggiornamento e l'inserimento di nuove password
        private bool UpdateWishlistMongoDB(EAction action, string cardName, int nrCopies,
            [Optional] string cardNameOld, [Optional] int nrCopiesOld)
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
                        dictToInsert.Add("name", cardName);
                        dictToInsert.Add("nrCopies", nrCopies);

                        //InsertOne MongoDb
                        MongoDB.Client.GetDatabase("yugiohCardDb")
                            .GetCollection<Dictionary<string, object>>(nameCollection + "Wishlist")
                            .InsertOne(dictToInsert);

                        return true;
                    }
                    //In caso di Update
                    else if (action == EAction.Update)
                    {
                        //Filtro di ricerca
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("name", cardNameOld)
                             & Builders<Dictionary<string, object>>.Filter.Eq("nrCopies", nrCopiesOld);

                        //Update MongoDb
                        MongoDB.Client.GetDatabase("yugiohCardDb").GetCollection<Dictionary<string, object>>(nameCollection + "Wishlist")
                                .UpdateOne(searchFilter, Builders<Dictionary<string, object>>
                                .Update.Set("name", cardName).Set("nrCopies", nrCopies));

                        return true;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                /*
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);
                */
                return false;
            }
        }

        private void searchWishlistCardTextBox_TextChanged(object sender, EventArgs e)
        {

            timerWishlist.Stop();

            timerWishlist.Start();
        }

        private void timerWishlist_Tick(object sender, EventArgs e)
        {
            timerWishlist.Stop();

            SeeListWishlist();
        }

        private void wishlistDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Controllo per la riga e la colonna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //Colonna di Update
                if (e.ColumnIndex == 5)
                {
                    //Apertura Form di Update
                    AddCardForm acf = new AddCardForm(apiResList, wishlistDataGridView[1, e.RowIndex].Value.ToString(), int.Parse(wishlistDataGridView[3, e.RowIndex].Value.ToString()));
                    acf.ShowDialog();

                    if (acf.DialogResult == DialogResult.OK)
                    {
                        //Aggiornamento Dati
                        UpdateWishlistMongoDB(EAction.Update,
                            acf.cardTextBox.Text,
                            int.Parse(acf.copiesNumericUpDown.Value.ToString()),
                            wishlistDataGridView[1, e.RowIndex].Value.ToString(),
                            int.Parse(wishlistDataGridView[3, e.RowIndex].Value.ToString()));

                        //Aggiornamento Lista
                        UpdateListWishlist();
                    }
                }
                //Colonna di delete
                else if (e.ColumnIndex == 6)
                {
                    ConfermForm cf = new ConfermForm();
                    cf.ShowDialog();

                    if (cf.DialogResult == DialogResult.OK)
                    {
                        //Creazione Filtro
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("name", wishlistDataGridView[1, e.RowIndex].Value.ToString())
                             & Builders<Dictionary<string, object>>.Filter.Eq("nrCopies", int.Parse(wishlistDataGridView[3, e.RowIndex].Value.ToString()));

                        //Eliminazione in base al filtro
                        MongoDB.Client.GetDatabase("yugiohCardDb").GetCollection<Dictionary<string, object>>(nameCollection + "Wishlist")
                            .DeleteOne(searchFilter);

                        //Aggiornamento Lista
                        UpdateListWishlist();
                    }
                }
            }
        }

        private void searcMyDeckTextBox_TextChanged(object sender, EventArgs e)
        {
            timerMyDeck.Stop();

            timerMyDeck.Start();
        }

        private void timerMyDeck_Tick(object sender, EventArgs e)
        {
            timerMyDeck.Stop();

            SeeListMyDeck();
        }

        private void insertMyDeckButton_Click(object sender, EventArgs e)
        {
            AddDeckForm adf = new AddDeckForm();
            adf.ShowDialog();

            if (adf.DialogResult == DialogResult.OK)
            {
                UpdateMyDeckMongoDB(EAction.Insert, adf.deckTextBox.Text);

                UpdateListMyDeck();
            }
        }

        //Metodo per l'aggiornamento e l'inserimento di nuove password
        private bool UpdateMyDeckMongoDB(EAction action, string deckName, [Optional] string deckNameOld)
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
                        dictToInsert.Add("name", deckName);

                        //InsertOne MongoDb
                        MongoDB.Client.GetDatabase("yugiohCardDb")
                            .GetCollection<Dictionary<string, object>>(nameCollection + "MyDeck")
                            .InsertOne(dictToInsert);

                        #region Creation Collection For Deck
                        var listCollection = MongoDB.Client
                        .GetDatabase("yugiohCardDb")
                        .ListCollectionNames()
                        .ToList();

                        bool collectionExist = false;
                        foreach (var item in listCollection)
                        {
                            if (item.Equals(nameCollection + deckName.ToLower().Replace(" ", "")))
                            {
                                collectionExist = true;
                                break;
                            }
                        }

                        if (collectionExist == false)
                        {
                            MongoDB.Client
                            .GetDatabase("yugiohCardDb")
                            .CreateCollection(nameCollection + deckName.ToLower().Replace(" ", ""));

                        }
                        else if (collectionExist == true)
                        {
                            //Console.WriteLine("Collection (Deck) già esistente");
                        }
                        #endregion Creation Collection For Deck

                        return true;
                    }
                    //In caso di Update
                    else if (action == EAction.Update)
                    {
                        //Filtro di ricerca
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("name", deckNameOld);

                        //Update MongoDb
                        MongoDB.Client.GetDatabase("yugiohCardDb").GetCollection<Dictionary<string, object>>(nameCollection + "MyDeck")
                                .UpdateOne(searchFilter, Builders<Dictionary<string, object>>
                                .Update.Set("name", deckName));

                        #region Rename Collection For Deck
                        var listCollection = MongoDB.Client.GetDatabase("yugiohCardDb").ListCollectionNames().ToList();

                        bool collectionExist = false;
                        foreach (var item in listCollection)
                        {
                            if (item.Equals(nameCollection + deckNameOld.ToLower().Replace(" ", "")))
                            {
                                collectionExist = true;
                                break;
                            }
                        }

                        if (collectionExist == true)
                        {
                            MongoDB.Client.GetDatabase("yugiohCardDb").RenameCollection(nameCollection + deckNameOld.ToLower().Replace(" ", ""), nameCollection + deckName.ToLower().Replace(" ", ""));
                        }
                        else if (collectionExist == false)
                        {
                            //Console.WriteLine("Nessuna Collection già esistente da rinominare");
                        }
                        #endregion Rename Collection For Deck

                        return true;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                /*
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);
                */
                return false;
            }
        }

        private void selectDeckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListSeeDeck();
        }

        private void searchSeeCardCardTextBox_TextChanged(object sender, EventArgs e)
        {

            timerSeeDeck.Stop();

            timerSeeDeck.Start();
        }

        private void timerSeeDeck_Tick(object sender, EventArgs e)
        {
            timerSeeDeck.Stop();

            SeeListSeeDeck();
        }

        private void insertSeeDeckButton_Click(object sender, EventArgs e)
        {
            AddCardForm acf = new AddCardForm(apiResList);
            acf.ShowDialog();

            if (acf.DialogResult == DialogResult.OK)
            {
                //Aggiornamento Dati
                UpdateSeeDeckMongoDB(EAction.Insert,
                    acf.cardTextBox.Text,
                    int.Parse(acf.copiesNumericUpDown.Value.ToString()));

                //Aggiornamento tab
                UpdateListSeeDeck();
            }
        }

        //Metodo per l'aggiornamento e l'inserimento di nuove password
        private bool UpdateSeeDeckMongoDB(EAction action, string cardName, int nrCopies,
            [Optional] string cardNameOld, [Optional] int nrCopiesOld)
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
                        dictToInsert.Add("name", cardName);
                        dictToInsert.Add("nrCopies", nrCopies);

                        //InsertOne MongoDb
                        MongoDB.Client.GetDatabase("yugiohCardDb")
                            .GetCollection<Dictionary<string, object>>(nameCollection + selectDeckComboBox.Text.ToLower().Replace(" ", ""))
                            .InsertOne(dictToInsert);

                        return true;
                    }
                    //In caso di Update
                    else if (action == EAction.Update)
                    {
                        //Filtro di ricerca
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("name", cardNameOld)
                             & Builders<Dictionary<string, object>>.Filter.Eq("nrCopies", nrCopiesOld);

                        //Update MongoDb
                        MongoDB.Client.GetDatabase("yugiohCardDb").GetCollection<Dictionary<string, object>>(nameCollection + selectDeckComboBox.Text.ToLower().Replace(" ", ""))
                                .UpdateOne(searchFilter, Builders<Dictionary<string, object>>
                                .Update.Set("name", cardName).Set("nrCopies", nrCopies));

                        return true;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                /*
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);
                */
                return false;
            }
        }

        private void exportYdkButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            if (folderBrowserDialog.SelectedPath != null)
            {
                List<Dictionary<string, object>> newList = mongoDbSeeDeck.Join(apiResList, item1 => item1["name"].ToString().ToLower(), item2 => item2["name"].ToString().ToLower(), (item1, item2) => new Dictionary<string, object> {
                    { "name", item1["name"].ToString() },
                    { "type", item2["type"].ToString() },
                    { "imageId", item2["imageId"].ToString() }
                }).ToList();

                List<string> mainCardList = newList.Where(p => !p["type"].ToString().ToLower().Contains("fusion")
                        && !p["type"].ToString().ToLower().Contains("synchro")
                        && !p["type"].ToString().ToLower().Contains("xyz")
                        && !p["type"].ToString().ToLower().Contains("link"))
                    .Select(p => new string(p["imageId"].ToString().ToCharArray()))
                    .ToList();

                List<string> extraCardList = newList.Where(p => p["type"].ToString().ToLower().Contains("fusion")
                        || p["type"].ToString().ToLower().Contains("synchro")
                        || p["type"].ToString().ToLower().Contains("xyz")
                        || p["type"].ToString().ToLower().Contains("link"))
                    .Select(p => new string(p["imageId"].ToString().ToCharArray()))
                    .ToList();

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("#created by " + nameCollection + " (GitHub.link)");
                sb.AppendLine("#main");

                mainCardList.ForEach(p =>
                    sb.AppendLine(p)
                );

                sb.AppendLine("#extra");

                extraCardList.ForEach(p =>
                    sb.AppendLine(p)
                );

                sb.AppendLine("!side");

                File.WriteAllText(folderBrowserDialog.SelectedPath + "\\" + selectDeckComboBox.Text.ToLower().Replace(" ", "") + ".ydk", sb.ToString());
            }
        }

        private void importYdkButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != null && openFileDialog.FileName.EndsWith(".ydk"))
            {
                string allYdkText = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                int indexYdkStart = allYdkText.IndexOf("#main");
                int indexYdkEnd = allYdkText.IndexOf("!side");
                if (indexYdkEnd == -1)
                {
                    indexYdkEnd = allYdkText.Length;
                }
                string newYdkText = allYdkText.Substring(indexYdkStart, indexYdkEnd - indexYdkStart).Replace("#main", "").Replace("#extra", "").Replace("\r\n", " ").TrimStart();
                newYdkText = Regex.Replace(newYdkText, @"\s+", " ");

                List<string> idListFromYdk = new List<string>();

                string textToInsert = "";
                foreach (char c in newYdkText)
                {
                    if (c == 32)
                    {
                        idListFromYdk.Add(textToInsert);
                        textToInsert = "";
                    }
                    else
                    {
                        textToInsert += c;
                    }
                }

                Dictionary<string, int> listToInsert = new Dictionary<string, int>();
                List<string> idListSingle = new List<string>();

                foreach (var item in idListFromYdk)
                {
                    string cardName = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == int.Parse(item)).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                    if (cardName != null)
                    {
                        if (!listToInsert.ContainsKey(cardName))
                        {
                            listToInsert.Add(cardName, 1);
                            idListSingle.Add(cardName);
                        }
                        else
                        {
                            listToInsert[cardName]++;
                        }

                    }

                }

                idListSingle.ForEach(p =>
                    UpdateSeeDeckMongoDB(EAction.Insert,
                        p,
                        listToInsert[p]
                    )
                );

                //Aggiornamento tab
                UpdateListSeeDeck();

                //Aggiornamento vista deck
                UpdateListMyDeck();
            }
        }

        private void myDeckDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Controllo per la riga e la colonna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //Colonna di Update
                if (e.ColumnIndex == 4)
                {
                    //Apertura Form di Update
                    AddDeckForm adf = new AddDeckForm(myDeckDataGridView[0, e.RowIndex].Value.ToString());
                    adf.ShowDialog();

                    if (adf.DialogResult == DialogResult.OK)
                    {
                        //Aggiornamento Dati
                        UpdateMyDeckMongoDB(EAction.Update,
                            adf.deckTextBox.Text,
                            myDeckDataGridView[0, e.RowIndex].Value.ToString());

                        //Aggiornamento Lista
                        UpdateListMyDeck();
                    }
                }
                //Colonna di delete
                else if (e.ColumnIndex == 5)
                {
                    ConfermForm cf = new ConfermForm();
                    cf.ShowDialog();

                    if (cf.DialogResult == DialogResult.OK)
                    {
                        //Creazione Filtro
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("name", myDeckDataGridView[0, e.RowIndex].Value.ToString());

                        //Eliminazione in base al filtro
                        MongoDB.Client.GetDatabase("yugiohCardDb").GetCollection<Dictionary<string, object>>(nameCollection + "MyDeck")
                            .DeleteOne(searchFilter);

                        #region Remove Collection For Deck
                        var listCollection = MongoDB.Client
                        .GetDatabase("yugiohCardDb")
                        .ListCollectionNames()
                        .ToList();

                        bool collectionExist = false;
                        foreach (var item in listCollection)
                        {
                            if (item.Equals(nameCollection + myDeckDataGridView[0, e.RowIndex].Value.ToString().ToLower().Replace(" ", "")))
                            {
                                collectionExist = true;
                                break;
                            }
                        }

                        if (collectionExist == true)
                        {
                            MongoDB.Client
                            .GetDatabase("yugiohCardDb")
                            .DropCollection(nameCollection + myDeckDataGridView[0, e.RowIndex].Value.ToString().ToLower().Replace(" ", ""));

                        }
                        else if (collectionExist == false)
                        {
                            //Console.WriteLine("Collection (Deck) già esistente");
                        }
                        #endregion Remove Collection For Deck

                        //Aggiornamento Lista
                        UpdateListMyDeck();
                    }
                }
            }
        }

        private void seeDeckDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Controllo per la riga e la colonna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //Colonna di Update
                if (e.ColumnIndex == 5)
                {
                    //Apertura Form di Update
                    AddCardForm acf = new AddCardForm(apiResList, seeDeckDataGridView[1, e.RowIndex].Value.ToString(), int.Parse(seeDeckDataGridView[3, e.RowIndex].Value.ToString()));
                    acf.ShowDialog();

                    if (acf.DialogResult == DialogResult.OK)
                    {
                        //Aggiornamento Dati
                        UpdateSeeDeckMongoDB(EAction.Update,
                            acf.cardTextBox.Text,
                            int.Parse(acf.copiesNumericUpDown.Value.ToString()),
                            seeDeckDataGridView[1, e.RowIndex].Value.ToString(),
                            int.Parse(seeDeckDataGridView[3, e.RowIndex].Value.ToString()));

                        //Aggiornamento Lista
                        UpdateListSeeDeck();
                    }
                }
                //Colonna di delete
                else if (e.ColumnIndex == 6)
                {
                    ConfermForm cf = new ConfermForm();
                    cf.ShowDialog();

                    if (cf.DialogResult == DialogResult.OK)
                    {
                        //Creazione Filtro
                        var searchFilter = Builders<Dictionary<string, object>>.Filter.Eq("name", seeDeckDataGridView[1, e.RowIndex].Value.ToString())
                             & Builders<Dictionary<string, object>>.Filter.Eq("nrCopies", int.Parse(seeDeckDataGridView[3, e.RowIndex].Value.ToString()));

                        //Eliminazione in base al filtro
                        MongoDB.Client.GetDatabase("yugiohCardDb").GetCollection<Dictionary<string, object>>(nameCollection + selectDeckComboBox.Text.ToLower().Replace(" ", ""))
                            .DeleteOne(searchFilter);

                        //Aggiornamento Lista
                        UpdateListSeeDeck();
                    }
                }
            }
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
