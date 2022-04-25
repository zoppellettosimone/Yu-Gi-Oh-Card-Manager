
namespace YuGiOhCardManager
{
    partial class LoginForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.footerPanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.headerCreditsLabel = new System.Windows.Forms.Label();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.errPasswordLabel = new System.Windows.Forms.Label();
            this.errorNotify = new ReaLTaiizor.Controls.HopeNotify();
            this.loginButton = new ReaLTaiizor.Controls.ParrotButton();
            this.seePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.infoLoginButtonLabel = new System.Windows.Forms.Label();
            this.passwordTextLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.footerPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.fillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.footerPanel.Controls.Add(this.versionLabel);
            this.footerPanel.Controls.Add(this.footerCreditLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(1, 589);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(518, 65);
            this.footerPanel.TabIndex = 0;
            // 
            // versionLabel
            // 
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Location = new System.Drawing.Point(0, 0);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(139, 65);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version 1.1";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footerCreditLabel
            // 
            this.footerCreditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerCreditLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.footerCreditLabel.ForeColor = System.Drawing.Color.Gray;
            this.footerCreditLabel.Location = new System.Drawing.Point(0, 0);
            this.footerCreditLabel.Name = "footerCreditLabel";
            this.footerCreditLabel.Size = new System.Drawing.Size(518, 65);
            this.footerCreditLabel.TabIndex = 1;
            this.footerCreditLabel.Text = "Created By Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.headerPanel.Controls.Add(this.closeAllButton);
            this.headerPanel.Controls.Add(this.headerCreditsLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(1, 1);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(518, 65);
            this.headerPanel.TabIndex = 1;
            // 
            // closeAllButton
            // 
            this.closeAllButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAllButton.FlatAppearance.BorderSize = 0;
            this.closeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAllButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.closeAllButton.ForeColor = System.Drawing.Color.Gray;
            this.closeAllButton.Location = new System.Drawing.Point(461, 0);
            this.closeAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(57, 65);
            this.closeAllButton.TabIndex = 3;
            this.closeAllButton.Text = "❌";
            this.closeAllButton.UseVisualStyleBackColor = true;
            this.closeAllButton.Click += new System.EventHandler(this.closeAllButton_Click);
            // 
            // headerCreditsLabel
            // 
            this.headerCreditsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerCreditsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.headerCreditsLabel.ForeColor = System.Drawing.Color.Gray;
            this.headerCreditsLabel.Location = new System.Drawing.Point(0, 0);
            this.headerCreditsLabel.Name = "headerCreditsLabel";
            this.headerCreditsLabel.Size = new System.Drawing.Size(518, 65);
            this.headerCreditsLabel.TabIndex = 2;
            this.headerCreditsLabel.Text = "Yu-Gi-Oh Card Manager";
            this.headerCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerCreditsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerCreditsLabel_MouseMove);
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.fillPanel.Controls.Add(this.errPasswordLabel);
            this.fillPanel.Controls.Add(this.errorNotify);
            this.fillPanel.Controls.Add(this.loginButton);
            this.fillPanel.Controls.Add(this.seePasswordCheckBox);
            this.fillPanel.Controls.Add(this.passwordTextBox);
            this.fillPanel.Controls.Add(this.userTextBox);
            this.fillPanel.Controls.Add(this.userLabel);
            this.fillPanel.Controls.Add(this.title2Label);
            this.fillPanel.Controls.Add(this.infoLoginButtonLabel);
            this.fillPanel.Controls.Add(this.passwordTextLabel);
            this.fillPanel.Controls.Add(this.titleLabel);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(1, 66);
            this.fillPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(518, 523);
            this.fillPanel.TabIndex = 2;
            // 
            // errPasswordLabel
            // 
            this.errPasswordLabel.AutoSize = true;
            this.errPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.errPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errPasswordLabel.Location = new System.Drawing.Point(220, 475);
            this.errPasswordLabel.Name = "errPasswordLabel";
            this.errPasswordLabel.Size = new System.Drawing.Size(189, 28);
            this.errPasswordLabel.TabIndex = 15;
            this.errPasswordLabel.Text = "Wrong Password !!!";
            this.errPasswordLabel.Visible = false;
            // 
            // errorNotify
            // 
            this.errorNotify.Close = true;
            this.errorNotify.CloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(154)))));
            this.errorNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorNotify.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.errorNotify.ErrorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.errorNotify.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.errorNotify.InfoBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.errorNotify.InfoTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.errorNotify.Location = new System.Drawing.Point(67, 475);
            this.errorNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorNotify.Name = "errorNotify";
            this.errorNotify.Size = new System.Drawing.Size(147, 34);
            this.errorNotify.SuccessBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.errorNotify.SuccessTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.errorNotify.TabIndex = 14;
            this.errorNotify.Text = "ERROR";
            this.errorNotify.Type = ReaLTaiizor.Controls.HopeNotify.AlertType.Error;
            this.errorNotify.Visible = false;
            this.errorNotify.WarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.errorNotify.WarningTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.errorNotify.Click += new System.EventHandler(this.errorNotify_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.loginButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("loginButton.ButtonImage")));
            this.loginButton.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.loginButton.ButtonText = "Login";
            this.loginButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.loginButton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.loginButton.CornerRadius = 5;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.loginButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.loginButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.loginButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.loginButton.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.loginButton.Location = new System.Drawing.Point(211, 405);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 50);
            this.loginButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.loginButton.TabIndex = 13;
            this.loginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.loginButton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.loginButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // seePasswordCheckBox
            // 
            this.seePasswordCheckBox.AutoSize = true;
            this.seePasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seePasswordCheckBox.ForeColor = System.Drawing.Color.Gray;
            this.seePasswordCheckBox.Location = new System.Drawing.Point(356, 274);
            this.seePasswordCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seePasswordCheckBox.Name = "seePasswordCheckBox";
            this.seePasswordCheckBox.Size = new System.Drawing.Size(120, 24);
            this.seePasswordCheckBox.TabIndex = 12;
            this.seePasswordCheckBox.Text = "See Password";
            this.seePasswordCheckBox.UseVisualStyleBackColor = true;
            this.seePasswordCheckBox.CheckedChanged += new System.EventHandler(this.seePasswordCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(197, 270);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(144, 27);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userTextBox.Location = new System.Drawing.Point(197, 191);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(144, 27);
            this.userTextBox.TabIndex = 10;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userLabel.ForeColor = System.Drawing.Color.Gray;
            this.userLabel.Location = new System.Drawing.Point(131, 194);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(41, 20);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "User:";
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.title2Label.ForeColor = System.Drawing.Color.Gray;
            this.title2Label.Location = new System.Drawing.Point(212, 82);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(84, 37);
            this.title2Label.TabIndex = 8;
            this.title2Label.Text = "Login";
            // 
            // infoLoginButtonLabel
            // 
            this.infoLoginButtonLabel.AutoSize = true;
            this.infoLoginButtonLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.infoLoginButtonLabel.ForeColor = System.Drawing.Color.Gray;
            this.infoLoginButtonLabel.Location = new System.Drawing.Point(117, 353);
            this.infoLoginButtonLabel.Name = "infoLoginButtonLabel";
            this.infoLoginButtonLabel.Size = new System.Drawing.Size(284, 23);
            this.infoLoginButtonLabel.TabIndex = 7;
            this.infoLoginButtonLabel.Text = "Press Enter or Press Button to Login";
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.AutoSize = true;
            this.passwordTextLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextLabel.Location = new System.Drawing.Point(99, 272);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(73, 20);
            this.passwordTextLabel.TabIndex = 6;
            this.passwordTextLabel.Text = "Password:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Gray;
            this.titleLabel.Location = new System.Drawing.Point(11, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 57);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Yu-Gi-Oh Card Manager";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 655);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.footerPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label footerCreditLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Label headerCreditsLabel;
        private System.Windows.Forms.Button closeAllButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Label infoLoginButtonLabel;
        private System.Windows.Forms.Label passwordTextLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private ReaLTaiizor.Controls.ParrotButton loginButton;
        private System.Windows.Forms.CheckBox seePasswordCheckBox;
        private System.Windows.Forms.Label errPasswordLabel;
        private ReaLTaiizor.Controls.HopeNotify errorNotify;
        private System.Windows.Forms.Label versionLabel;
    }
}

