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

        int nrSets = 0;

        public OpenImageForm(Dictionary<string, object> card)
        {

            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            nrSets = 0;

            var file = d.GetFiles(card["imageId"].ToString() + ".jpg");

            if (file.Length == 1)
            {

                pictureBox.Image = Image.FromFile(file[0].FullName);

            }
            else
            {
                pictureBox.Image = Resources.unknownCard;
            }

            //variabile True se l'API è attiva e False in caso di risposta non avuta
            bool statusAPI = checkApiLive();

            nrSets = ((List<Dictionary<string, object>>)card["sets"]).Count();

            //DA MODIFICARE
            foreach (var s in (List<Dictionary<string, object>>)card["sets"])
            {

                if (statusAPI == true)
                {
                    requestPriceAPI(s);

                    
                }
                else
                {
                    if (s.ContainsKey("price") == false)
                    {
                        s.Add("price", 0.0);
                    }
                    else
                    {
                        s["price"] = 0.0;
                    }
                }
                
            }

            if (statusAPI == true)
            {
                while (nrSets != 0) { }
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

        //Metodo per controllare se l'API funziona correttamente o no
        private bool checkApiLive()
        {
            // Stringa Json dalla chiamata Api
            string jsonStringFromMyApi = "";

            //Chiamata My Api
            Uri addressMyApi = new Uri($"http://127.0.0.1:8000/iAmLive");
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

                return false;
            }

            //Controllo non sia vuota
            if (!jsonStringFromMyApi.Replace(" ", "").Equals(""))
            {
                try
                {
                    //Conversione da Json String a Json
                    var allJsonFromMyApi = JObject.Parse(jsonStringFromMyApi);
                    
                    return Boolean.Parse(allJsonFromMyApi["response"].ToString());
                }
                catch (Exception err)
                {
                    string Message = $"{err.StackTrace}\n{err.Message}";
                    Console.WriteLine(Message);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Metodo per controllare se l'API funziona correttamente o no
        private async void requestPriceAPI(Dictionary<string, object> s)
        {
            // Stringa Json dalla chiamata Api
            string jsonStringFromMyApi = "";

            //Chiamata My Api
            Uri addressMyApi = new Uri($"http://127.0.0.1:8000/yugioh/searchCard/min/" + s["set"].ToString());
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
            }

            //Controllo non sia vuota
            if (!jsonStringFromMyApi.Replace(" ", "").Equals(""))
            {
                try
                {
                    //Conversione da Json String a Json
                    var allJsonFromMyApi = JObject.Parse(jsonStringFromMyApi);
                    if (s.ContainsKey("price") == false)
                    {
                        s.Add("price", double.Parse(allJsonFromMyApi["price"].ToString()));
                    }
                    else
                    {
                        s["price"] = double.Parse(allJsonFromMyApi["price"].ToString());
                    }
                }
                catch (Exception err)
                {
                    string Message = $"{err.StackTrace}\n{err.Message}";
                    Console.WriteLine(Message);

                    if (s.ContainsKey("price") == false)
                    {
                        s.Add("price", 0.0);
                    }
                    else
                    {
                        s["price"] = 0.0;
                    }
                }
            }
            else
            {
                if (s.ContainsKey("price") == false)
                {
                    s.Add("price", 0.0);
                }
                else
                {
                    s["price"] = 0.0;
                }
            }

            nrSets -= 1;
        }
    }
}
