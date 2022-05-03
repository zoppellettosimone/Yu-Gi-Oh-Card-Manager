namespace YuGiOhCardManager
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.headerCreditsLabel = new System.Windows.Forms.Label();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.confermButton = new ReaLTaiizor.Controls.ParrotButton();
            this.infoLoginButtonLabel = new System.Windows.Forms.Label();
            this.seePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordTextLabel = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.fillPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.headerPanel.Controls.Add(this.closeAllButton);
            this.headerPanel.Controls.Add(this.headerCreditsLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(1, 1);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(523, 53);
            this.headerPanel.TabIndex = 0;
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.fillPanel.Controls.Add(this.title2Label);
            this.fillPanel.Controls.Add(this.titleLabel);
            this.fillPanel.Controls.Add(this.seePasswordCheckBox);
            this.fillPanel.Controls.Add(this.passwordTextBox);
            this.fillPanel.Controls.Add(this.userTextBox);
            this.fillPanel.Controls.Add(this.userLabel);
            this.fillPanel.Controls.Add(this.passwordTextLabel);
            this.fillPanel.Controls.Add(this.confermButton);
            this.fillPanel.Controls.Add(this.infoLoginButtonLabel);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(1, 54);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(523, 439);
            this.fillPanel.TabIndex = 1;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.footerPanel.Controls.Add(this.versionLabel);
            this.footerPanel.Controls.Add(this.footerCreditLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(1, 440);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(523, 53);
            this.footerPanel.TabIndex = 1;
            // 
            // footerCreditLabel
            // 
            this.footerCreditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerCreditLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.footerCreditLabel.ForeColor = System.Drawing.Color.Gray;
            this.footerCreditLabel.Location = new System.Drawing.Point(0, 0);
            this.footerCreditLabel.Name = "footerCreditLabel";
            this.footerCreditLabel.Size = new System.Drawing.Size(523, 53);
            this.footerCreditLabel.TabIndex = 2;
            this.footerCreditLabel.Text = "Created By Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Location = new System.Drawing.Point(0, 0);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(139, 53);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version 1.2";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerCreditsLabel
            // 
            this.headerCreditsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerCreditsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.headerCreditsLabel.ForeColor = System.Drawing.Color.Gray;
            this.headerCreditsLabel.Location = new System.Drawing.Point(0, 0);
            this.headerCreditsLabel.Name = "headerCreditsLabel";
            this.headerCreditsLabel.Size = new System.Drawing.Size(523, 53);
            this.headerCreditsLabel.TabIndex = 3;
            this.headerCreditsLabel.Text = "Yu-Gi-Oh Card Manager";
            this.headerCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerCreditsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerCreditsLabel_MouseMove);
            // 
            // closeAllButton
            // 
            this.closeAllButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAllButton.FlatAppearance.BorderSize = 0;
            this.closeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAllButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.closeAllButton.ForeColor = System.Drawing.Color.Gray;
            this.closeAllButton.Location = new System.Drawing.Point(466, 0);
            this.closeAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(57, 53);
            this.closeAllButton.TabIndex = 4;
            this.closeAllButton.Text = "❌";
            this.closeAllButton.UseVisualStyleBackColor = true;
            this.closeAllButton.Click += new System.EventHandler(this.closeAllButton_Click);
            // 
            // confermButton
            // 
            this.confermButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.confermButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("confermButton.ButtonImage")));
            this.confermButton.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.confermButton.ButtonText = "Conferm";
            this.confermButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.confermButton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.confermButton.CornerRadius = 5;
            this.confermButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confermButton.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.confermButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.confermButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.confermButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.confermButton.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.confermButton.Location = new System.Drawing.Point(203, 323);
            this.confermButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confermButton.Name = "confermButton";
            this.confermButton.Size = new System.Drawing.Size(100, 50);
            this.confermButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.confermButton.TabIndex = 27;
            this.confermButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.confermButton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.confermButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.confermButton.Click += new System.EventHandler(this.confermButton_Click);
            // 
            // infoLoginButtonLabel
            // 
            this.infoLoginButtonLabel.AutoSize = true;
            this.infoLoginButtonLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.infoLoginButtonLabel.ForeColor = System.Drawing.Color.Gray;
            this.infoLoginButtonLabel.Location = new System.Drawing.Point(99, 272);
            this.infoLoginButtonLabel.Name = "infoLoginButtonLabel";
            this.infoLoginButtonLabel.Size = new System.Drawing.Size(308, 23);
            this.infoLoginButtonLabel.TabIndex = 26;
            this.infoLoginButtonLabel.Text = "Press Enter or Press Button to Conferm";
            // 
            // seePasswordCheckBox
            // 
            this.seePasswordCheckBox.AutoSize = true;
            this.seePasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seePasswordCheckBox.ForeColor = System.Drawing.Color.Gray;
            this.seePasswordCheckBox.Location = new System.Drawing.Point(352, 232);
            this.seePasswordCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seePasswordCheckBox.Name = "seePasswordCheckBox";
            this.seePasswordCheckBox.Size = new System.Drawing.Size(120, 24);
            this.seePasswordCheckBox.TabIndex = 32;
            this.seePasswordCheckBox.Text = "See Password";
            this.seePasswordCheckBox.UseVisualStyleBackColor = true;
            this.seePasswordCheckBox.CheckedChanged += new System.EventHandler(this.seePasswordCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(193, 228);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(144, 27);
            this.passwordTextBox.TabIndex = 31;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userTextBox.Location = new System.Drawing.Point(193, 149);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(144, 27);
            this.userTextBox.TabIndex = 30;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userLabel.ForeColor = System.Drawing.Color.Gray;
            this.userLabel.Location = new System.Drawing.Point(127, 152);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(41, 20);
            this.userLabel.TabIndex = 29;
            this.userLabel.Text = "User:";
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.AutoSize = true;
            this.passwordTextLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextLabel.Location = new System.Drawing.Point(95, 230);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(73, 20);
            this.passwordTextLabel.TabIndex = 28;
            this.passwordTextLabel.Text = "Password:";
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.title2Label.ForeColor = System.Drawing.Color.Gray;
            this.title2Label.Location = new System.Drawing.Point(172, 76);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(183, 37);
            this.title2Label.TabIndex = 34;
            this.title2Label.Text = "Add New user";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Gray;
            this.titleLabel.Location = new System.Drawing.Point(27, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 57);
            this.titleLabel.TabIndex = 33;
            this.titleLabel.Text = "Yu-Gi-Oh Card Manager";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 494);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Add New User";
            this.headerPanel.ResumeLayout(false);
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label footerCreditLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label headerCreditsLabel;
        private System.Windows.Forms.Button closeAllButton;
        private ReaLTaiizor.Controls.ParrotButton confermButton;
        private System.Windows.Forms.Label infoLoginButtonLabel;
        private System.Windows.Forms.CheckBox seePasswordCheckBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordTextLabel;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox userTextBox;
    }
}