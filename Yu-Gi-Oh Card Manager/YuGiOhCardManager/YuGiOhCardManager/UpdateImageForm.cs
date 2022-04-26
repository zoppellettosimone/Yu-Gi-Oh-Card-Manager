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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOhCardManager
{
    public partial class UpdateImageForm : Form
    {
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        ManualResetEvent MRE = new ManualResetEvent(false);

        List<Dictionary<string, object>> apiResList = new List<Dictionary<string, object>>();

        DirectoryInfo d = new DirectoryInfo("..\\..\\..\\..\\..\\pics");

        public UpdateImageForm(List<Dictionary<string, object>> apiToCopy)
        {
            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            apiResList = apiToCopy;

            MRE.Reset();

            int nrFile = apiResList.Count() - d.GetFiles("*.jpg").Length;
            if(nrFile < 0)
            {
                nrFile = 0;
            }

            if (nrFile > 0)
            {
                updateImageButton.Enabled = true;
            }
            else
            {
                updateImageButton.Enabled = false;
            }

            nrImageLabel.Text = $"You have {nrFile} image to Download";
            timeLabel.Text = $"[{DateTime.Now}] {Math.Truncate(nrFile * 5.1)} sec to wait";

            wf.Close();
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            MRE.Set();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void updateImageButton_Click(object sender, EventArgs e)
        {
            nrImageLabel.Text = "Download Start. Wait until the download is complete...";
            nrImageLabel.Refresh();

            updateImageButton.Enabled = false;
            updateImageButton.Refresh();

            downloadPanel.Visible = true;
            downloadPanel.Refresh();

            Thread t1 = new Thread(() =>
            {

                foreach (var item in apiResList)
                {
                    if (d.GetFiles(item["imageId"].ToString() + ".jpg").Length == 0)
                    {
                        int nrFile = apiResList.Count() - d.GetFiles("*.jpg").Length;
                        if (nrFile < 0)
                        {
                            nrFile = 0;
                        }

                        if (InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                if (nrFile > 0)
                                {
                                    updateImageButton.Enabled = true;
                                }
                                else
                                {
                                    updateImageButton.Enabled = false;
                                }
                                updateImageButton.Refresh();

                                nrImageLabel.Text = $"You are downloading {nrFile} images";
                                timeLabel.Text = $"[{DateTime.Now}] {Math.Truncate(nrFile * 5.1)} sec to wait";

                                nrImageLabel.Refresh();
                                timeLabel.Refresh();
                            }));
                        }

                        DownloadImageApi(item["imageId"].ToString());

                        if(MRE.WaitOne(1)){
                            Console.WriteLine("MRE Off");
                            break;
                        }
                    }
                }
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        int nrFile = apiResList.Count() - d.GetFiles("*.jpg").Length;
                        if (nrFile < 0)
                        {
                            nrFile = 0;
                        }

                        nrImageLabel.Text = $"You have {nrFile} image to Download";
                        nrImageLabel.Refresh();

                        timeLabel.Text = $"[{DateTime.Now}] Download End";
                        timeLabel.Refresh();

                        updateImageButton.Enabled = true;
                        updateImageButton.Refresh();

                        downloadPanel.Visible = false;
                        downloadPanel.Refresh();
                    }));
                }
            });
            t1.IsBackground = true;
            t1.Start();
        }

        private void DownloadImageApi(string id)
        {
            Stopwatch checkTime = new Stopwatch();

            string apiUrl = "https://storage.googleapis.com/ygoprodeck.com/pics/" + id + ".jpg";

            checkTime.Start();

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] dataArr = webClient.DownloadData(apiUrl);
                    //save file to local
                    File.WriteAllBytes(d.FullName + "\\" + id + ".jpg", dataArr);
                }

                checkTime.Stop();

                Console.WriteLine(checkTime.ElapsedMilliseconds);

                DateTime time = DateTime.Now;

                //while (DateTime.Now.Subtract(time).TotalSeconds < 5) { }

                Thread.Sleep(5000);

            }
            catch (Exception err)
            {
                string Message = $"{err.StackTrace}\n{err.Message}";
                Console.WriteLine(Message);

                Console.WriteLine(id);
            }
        }
    }
}
