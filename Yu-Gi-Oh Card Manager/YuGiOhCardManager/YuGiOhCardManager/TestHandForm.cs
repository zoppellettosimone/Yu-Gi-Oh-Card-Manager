using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuGiOhCardManager.Properties;

namespace YuGiOhCardManager
{
    public partial class TestHandForm : Form
    {
        List<int> idListFromYdk = new List<int>();
        List<int> idListFromYdkToUse = new List<int>();

        List<Dictionary<string, object>> apiResList = new List<Dictionary<string, object>>();

        int nrCard = 0;

        #region Emoji

        string squareVoidEmoji = "◻";
        string squareDoubleEmoji = "❐";

        #endregion Emoji

        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        DirectoryInfo d = new DirectoryInfo("..\\..\\..\\..\\..\\pics");

        public TestHandForm(List<Dictionary<string, object>> apiToPass)
        {
            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            apiResList = apiToPass;

            nameCardLabel1.Text = "";
            nameCardLabel2.Text = "";
            nameCardLabel3.Text = "";
            nameCardLabel4.Text = "";
            nameCardLabel5.Text = "";
            nameCardLabel6.Text = "";
            nameCardLabel7.Text = "";
            nameCardLabel8.Text = "";
            nameCardLabel9.Text = "";
            nameCardLabel10.Text = "";

            wf.Close();
        }

        public static void Shuffle(List<int> list)
        {
            for (int i = 0; i < 10000; i++)
            {
                Random rng = new Random();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    int value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
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
                string newYdkText = allYdkText.Substring(indexYdkStart, indexYdkEnd - indexYdkStart).Replace("#main", "").Replace("\r\n", " ").TrimStart();
                newYdkText = Regex.Replace(newYdkText, @"\s+", " ");

                idListFromYdk.Clear();
                string textToInsert = "";
                foreach (char c in newYdkText)
                {
                    if (c == 32)
                    {
                        if (!textToInsert.Equals("#extra"))
                        {
                            idListFromYdk.Add(int.Parse(textToInsert));
                            textToInsert = "";
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        textToInsert += c;
                    }
                }

                drawFive();

                shuffleButton.Enabled = true;
                plusOneButton.Enabled = true;
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            drawFive();
        }

        private void drawFive()
        {
            pictureBox6.Image = Resources.yugiohCardBack;
            pictureBox7.Image = Resources.yugiohCardBack;
            pictureBox8.Image = Resources.yugiohCardBack;
            pictureBox9.Image = Resources.yugiohCardBack;
            pictureBox10.Image = Resources.yugiohCardBack;

            nameCardLabel1.Text = "";
            nameCardLabel2.Text = "";
            nameCardLabel3.Text = "";
            nameCardLabel4.Text = "";
            nameCardLabel5.Text = "";
            nameCardLabel6.Text = "";
            nameCardLabel7.Text = "";
            nameCardLabel8.Text = "";
            nameCardLabel9.Text = "";
            nameCardLabel10.Text = "";

            idListFromYdkToUse.Clear();
            idListFromYdk.ForEach(p =>
                idListFromYdkToUse.Add(p)
            );

            nrCard = 5;

            //Stopwatch testSpeedShuffle = new Stopwatch();
            //testSpeedShuffle.Restart();

            Shuffle(idListFromYdkToUse);
            //testSpeedShuffle.Stop();

            //Console.WriteLine(testSpeedShuffle.ElapsedMilliseconds);

            if (idListFromYdkToUse.Count > 0)
            {
                try
                {
                    int img1 = idListFromYdkToUse[idListFromYdkToUse.Count - 1];
                    idListFromYdkToUse.RemoveAt(idListFromYdkToUse.Count - 1);
                    var fileImg1 = d.GetFiles(img1 + ".jpg");
                    if (fileImg1.Length > 0)
                    {
                        pictureBox1.Image = Image.FromFile(d + "\\" + img1.ToString() + ".jpg");
                    }
                    else
                    {
                        pictureBox1.Image = Resources.unknownCard;
                    }
                    var nameImg1 = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == img1).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                    if (nameImg1 != null && nameImg1.Length > 26)
                    {
                        nameImg1 = nameImg1.Substring(0, 26);
                    }
                    if (nameImg1 != null)
                    {
                        nameCardLabel1.Text = nameImg1;
                    }
                    else
                    {
                        nameCardLabel1.Text = "Card Not Found";
                    }

                    if (idListFromYdkToUse.Count > 0)
                    {
                        int img2 = idListFromYdkToUse[idListFromYdkToUse.Count - 1];
                        idListFromYdkToUse.RemoveAt(idListFromYdkToUse.Count - 1);
                        var fileImg2 = d.GetFiles(img2 + ".jpg");
                        if (fileImg2.Length > 0)
                        {
                            pictureBox2.Image = Image.FromFile(d + "\\" + img2.ToString() + ".jpg");
                        }
                        else
                        {
                            pictureBox2.Image = Resources.unknownCard;
                        }
                        var nameImg2 = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == img2).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                        if (nameImg2 != null && nameImg2.Length > 26)
                        {
                            nameImg2 = nameImg2.Substring(0, 26);
                        }
                        if (nameImg2 != null)
                        {
                            nameCardLabel2.Text = nameImg2;
                        }
                        else
                        {
                            nameCardLabel2.Text = "Card Not Found";
                        }

                        if (idListFromYdkToUse.Count > 0)
                        {
                            int img3 = idListFromYdkToUse[idListFromYdkToUse.Count - 1];
                            idListFromYdkToUse.RemoveAt(idListFromYdkToUse.Count - 1);
                            var fileImg3 = d.GetFiles(img3 + ".jpg");
                            if (fileImg3.Length > 0)
                            {
                                pictureBox3.Image = Image.FromFile(d + "\\" + img3.ToString() + ".jpg");
                            }
                            else
                            {
                                pictureBox3.Image = Resources.unknownCard;
                            }
                            var nameImg3 = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == img3).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                            if (nameImg3 != null && nameImg3.Length > 26)
                            {
                                nameImg3 = nameImg3.Substring(0, 26);
                            }
                            if (nameImg3 != null)
                            {
                                nameCardLabel3.Text = nameImg3;
                            }
                            else
                            {
                                nameCardLabel3.Text = "Card Not Found";
                            }

                            if (idListFromYdkToUse.Count > 0)
                            {
                                int img4 = idListFromYdkToUse[idListFromYdkToUse.Count - 1];
                                idListFromYdkToUse.RemoveAt(idListFromYdkToUse.Count - 1);
                                var fileImg4 = d.GetFiles(img4 + ".jpg");
                                if (fileImg4.Length > 0)
                                {
                                    pictureBox4.Image = Image.FromFile(d + "\\" + img4.ToString() + ".jpg");
                                }
                                else
                                {
                                    pictureBox4.Image = Resources.unknownCard;
                                }
                                var nameImg4 = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == img4).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                                if (nameImg4 != null && nameImg4.Length > 26)
                                {
                                    nameImg4 = nameImg4.Substring(0, 26);
                                }
                                if (nameImg4 != null)
                                {
                                    nameCardLabel4.Text = nameImg4;
                                }
                                else
                                {
                                    nameCardLabel4.Text = "Card Not Found";
                                }

                                if (idListFromYdkToUse.Count > 0)
                                {
                                    int img5 = idListFromYdkToUse[idListFromYdkToUse.Count - 1];
                                    idListFromYdkToUse.RemoveAt(idListFromYdkToUse.Count - 1);
                                    var fileImg5 = d.GetFiles(img5 + ".jpg");
                                    if (fileImg5.Length > 0)
                                    {
                                        pictureBox5.Image = Image.FromFile(d + "\\" + img5.ToString() + ".jpg");
                                    }
                                    else
                                    {
                                        pictureBox5.Image = Resources.unknownCard;
                                    }
                                    var nameImg5 = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == img5).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                                    if (nameImg5 != null && nameImg5.Length > 26)
                                    {
                                        nameImg5 = nameImg5.Substring(0, 26);
                                    }
                                    if (nameImg5 != null)
                                    {
                                        nameCardLabel5.Text = nameImg5;
                                    }
                                    else
                                    {
                                        nameCardLabel5.Text = "Card Not Found";
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    var a = err;
                }
            }
        }

        private void plusOneButton_Click(object sender, EventArgs e)
        {
            if (idListFromYdkToUse.Count > 0)
            {
                int img = idListFromYdkToUse[idListFromYdkToUse.Count - 1];
                idListFromYdkToUse.RemoveAt(idListFromYdkToUse.Count - 1);
                var fileImg = d.GetFiles(img + ".jpg");
                var nameImg = apiResList.Where(p => int.Parse(p["imageId"].ToString()) == img).Select(p => new string(p["name"].ToString().ToCharArray())).FirstOrDefault();
                if (nameImg != null && nameImg.Length > 26)
                {
                    nameImg = nameImg.Substring(0, 26);
                }
                if (fileImg.Length > 0)
                {
                    if (nrCard == 5)
                    {
                        nrCard++;
                        pictureBox6.Image = Image.FromFile(d + "\\" + img.ToString() + ".jpg");
                        if (nameImg != null)
                        {
                            nameCardLabel6.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel6.Text = "Card Not Found";
                        }

                    }
                    else if (nrCard == 6)
                    {
                        nrCard++;
                        pictureBox7.Image = Image.FromFile(d + "\\" + img.ToString() + ".jpg");
                        if (nameImg != null)
                        {
                            nameCardLabel7.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel7.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 7)
                    {
                        nrCard++;
                        pictureBox8.Image = Image.FromFile(d + "\\" + img.ToString() + ".jpg");
                        if (nameImg != null)
                        {
                            nameCardLabel8.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel8.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 8)
                    {
                        nrCard++;
                        pictureBox9.Image = Image.FromFile(d + "\\" + img.ToString() + ".jpg");
                        if (nameImg != null)
                        {
                            nameCardLabel9.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel9.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 9)
                    {
                        nrCard++;
                        pictureBox10.Image = Image.FromFile(d + "\\" + img.ToString() + ".jpg");
                        if (nameImg != null)
                        {
                            nameCardLabel10.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel10.Text = "Card Not Found";
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Numero Massimo di carte raggiunto");
                    }
                }
                else
                {
                    if (nrCard == 5)
                    {
                        nrCard++;
                        pictureBox6.Image = Resources.unknownCard;
                        if (nameImg != null)
                        {
                            nameCardLabel6.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel6.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 6)
                    {
                        nrCard++;
                        pictureBox7.Image = Resources.unknownCard;
                        if (nameImg != null)
                        {
                            nameCardLabel7.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel7.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 7)
                    {
                        nrCard++;
                        pictureBox8.Image = Resources.unknownCard;
                        if (nameImg != null)
                        {
                            nameCardLabel8.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel8.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 8)
                    {
                        nrCard++;
                        pictureBox9.Image = Resources.unknownCard;
                        if (nameImg != null)
                        {
                            nameCardLabel9.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel9.Text = "Card Not Found";
                        }
                    }
                    else if (nrCard == 9)
                    {
                        nrCard++;
                        pictureBox10.Image = Resources.unknownCard;
                        if (nameImg != null)
                        {
                            nameCardLabel10.Text = nameImg;
                        }
                        else
                        {
                            nameCardLabel10.Text = "Card Not Found";
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Numero Massimo di carte raggiunto");
                    }
                }
            }
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

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

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
