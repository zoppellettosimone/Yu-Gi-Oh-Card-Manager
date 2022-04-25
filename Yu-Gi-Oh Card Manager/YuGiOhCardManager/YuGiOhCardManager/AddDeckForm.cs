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
    public partial class AddDeckForm : Form
    {
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        public AddDeckForm()
        {
            WaitForm wf = new WaitForm();

            wf.Show();
            wf.Refresh();

            InitializeComponent();

            wf.Close();
        }

        public AddDeckForm(string name)
        {
            InitializeComponent();

            deckTextBox.Text = name;
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

        private void confermButton_Click(object sender, EventArgs e)
        {
            ConfermForm cf = new ConfermForm();
            cf.ShowDialog();

            if (cf.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
