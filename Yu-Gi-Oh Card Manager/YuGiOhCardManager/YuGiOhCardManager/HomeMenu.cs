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
    public partial class HomeMenu : Form
    {
        //Chiamata Api
        string apiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

        List<Dictionary<string, object>> apiResList = new List<Dictionary<string, object>>();

        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        public HomeMenu()
        {
            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            UpdateApi();

            wf.Close();
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFormButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm(apiResList);
            this.Visible = false;
            lf.ShowDialog();
            this.Visible = true;
        }

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
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion Move Form

        private void testHandButton_Click(object sender, EventArgs e)
        {
            TestHandForm thf = new TestHandForm(apiResList);
            this.Visible = false;
            thf.ShowDialog();
            this.Visible = true;
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

                var test = allJsonContent["data"].Where(p => p["name"].ToString().ToLower().Contains("mysterune")).ToList();

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

            }
            catch (Exception err)
            {
                /*
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);
                */
            }
        }

        private void checkImageButton_Click(object sender, EventArgs e)
        {
            UpdateImageForm uif = new UpdateImageForm(apiResList);
            this.Visible = false;
            uif.ShowDialog();
            this.Visible = true;
        }
    }
}
