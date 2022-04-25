using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOhCardManager
{
    public partial class LoginForm : Form
    {
        #region Field

        List<Dictionary<string, object>> apiResList = new List<Dictionary<string, object>>();

        List<Dictionary<string, object>> listPasswordMongoDB = new List<Dictionary<string, object>>();

        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        #endregion Field

        public LoginForm(List<Dictionary<string, object>> apiToPass)
        {
            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            addUser();

            apiResList = apiToPass;

            wf.Close();
        }

        #region Upload User

        private void addUser()
        {
            if (checkConnection() == true)
            {
                //Se è connesso

                listPasswordMongoDB = MongoDB.Client
                    .GetDatabase("yugiohCardDb")
                    .GetCollection<Dictionary<string, object>>("User")
                   .Find(Builders<Dictionary<string, object>>.Filter.Empty)
                   .ToList();
            }
            else
            {
                errorNotify.Visible = true;
                errPasswordLabel.Visible = true;

                errPasswordLabel.Text = "Non Connesso con MongoDb.";
            }
        }

        private bool checkConnection()
        {
            return MongoDB.IsConnected();
        }

        #endregion Upload User

        #region Login Button/Send
        //Quando viene premuto il Bottone per il Login
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Azione del pulsante
            buttonClick();
        }

        //Quando viene premuto il CheckBox per vedere la Password
        private void seePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //In caso la Password fosse criptata
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                //la rimostra in chiaro
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else if (passwordTextBox.UseSystemPasswordChar == false)
            {
                //In caso la Password fosse in chiaro
                //la rimostra in criptata
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        //Quando viene premuto un tasto nel TextBox della Password
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Se il tasto premuto è l'invio
            if (e.KeyCode == Keys.Enter)
            {
                //Azione del pulsante
                buttonClick();
            }
        }

        //Metodo chiamato quando si vuole fare il Login
        private void buttonClick()
        {
            //Check Password
            if (listPasswordMongoDB.Where(s => s["user"].ToString().Equals(userTextBox.Text) && s["password"].ToString().Equals(passwordTextBox.Text)).FirstOrDefault() != null)
            {
                //Nasconde questo Form
                this.Visible = false;


                MenuForm mf = new MenuForm(userTextBox.Text.Substring(0, 1).ToUpper() + userTextBox.Text.ToLower().Substring(1), apiResList);

                //Apre il Form di Menu
                mf.ShowDialog();

                //Mostra questo Form
                this.Visible = true;
            }
            else
            {
                errorNotify.Visible = true;
                errPasswordLabel.Visible = true;
            }
            //Reset password e user text box
            userTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void errorNotify_Click(object sender, EventArgs e)
        {
            errorNotify.Visible = false;
            errPasswordLabel.Visible = false;
        }
        #endregion Login Button/Send

        #region Form Move

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
        #endregion Form Move

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
