using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuGiOhCardManager.Properties;

namespace YuGiOhCardManager
{
    public partial class OpenImageForm : Form
    {
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        DirectoryInfo d = new DirectoryInfo("..\\..\\..\\..\\..\\pics");

        public OpenImageForm(Dictionary<string, object> card)
        {

            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            var file = d.GetFiles(card["imageId"].ToString() + ".jpg");

            if (file.Length == 1)
            {

                pictureBox.Image = Image.FromFile(file[0].FullName);

            }
            else
            {
                pictureBox.Image = Resources.unknownCard;
            }

            //Variabile usata per i controlli di connessione con l'API
            bool checkConnecgionAPI = true;

            foreach (var s in (List<Dictionary<string, object>>)card["sets"])
            {
                if(checkConnecgionAPI == true)
                {
                    // Stringa Json dalla chiamata Api
                    string jsonStringFromMyApi = "";

                    //Chiamata My Api
                    Uri addressMyApi = new Uri($"http://127.0.0.1:8000/searchCard/ {s["set"]}");
                    HttpWebRequest requestMyApi = WebRequest.Create(addressMyApi) as HttpWebRequest;
                    requestMyApi.Method = "GET";
                    requestMyApi.ContentType = "text/json";

                    try
                    {
                        //Salvataggio su "jsonString" della risposta
                        using (HttpWebResponse response = requestMyApi.GetResponse() as HttpWebResponse)
                        {
                            StreamReader reader = new StreamReader(response.GetResponseStream());
                            jsonStringFromMyApi = reader.ReadToEnd();
                        }
                    }
                    catch (Exception err)
                    {
                        string Message = $"{err.StackTrace}\n{err.Message}";
                        Console.WriteLine(Message);

                        //False = Errore con l'API
                        checkConnecgionAPI = false;
                    }

                    //Controllo non sia vuota
                    if (!jsonStringFromMyApi.Replace(" ", "").Equals(""))
                    {
                        try
                        {
                            //Conversione da Json String a Json
                            var allJsonFromMyApi = JObject.Parse(jsonStringFromMyApi);
                            s.Add("price", double.Parse(allJsonFromMyApi["price"].ToString()));
                        }
                        catch (Exception err)
                        {
                            string Message = $"{err.StackTrace}\n{err.Message}";
                            Console.WriteLine(Message);
                        }
                    }
                }
                else
                {
                    s.Add("price", 0.00);
                }

                
            }

            setsDataGridView.AllowUserToAddRows = true;

            setsDataGridView.Rows.Clear();

            try
            {
                foreach (var s in (List<Dictionary<string, object>>)card["sets"])
                {
                    DataGridViewRow row = (DataGridViewRow)setsDataGridView.Rows[0].Clone();

                    row.Cells[0].Value = s["set"].ToString();

                    row.Cells[1].Value = double.Parse(s["price"].ToString());

                    if (double.Parse(s["price"].ToString()) < 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (double.Parse(s["price"].ToString()) >= 3 && double.Parse(s["price"].ToString()) < 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (double.Parse(s["price"].ToString()) > 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }

                    setsDataGridView.Rows.Add(row);
                }
            }
            catch (Exception err)
            {
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);
            }

            setsDataGridView.AllowUserToAddRows = false;

            wf.Close();
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

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
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
