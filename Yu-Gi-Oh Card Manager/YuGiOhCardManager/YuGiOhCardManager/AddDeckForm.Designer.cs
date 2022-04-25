
namespace YuGiOhCardManager
{
    partial class AddDeckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeckForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.headerCreditsLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.confermButton = new ReaLTaiizor.Controls.ParrotButton();
            this.infoLoginButtonLabel = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deckTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.fillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.headerPanel.Controls.Add(this.closeAllButton);
            this.headerPanel.Controls.Add(this.headerCreditsLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(1, 1);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(518, 65);
            this.headerPanel.TabIndex = 0;
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
            this.closeAllButton.TabIndex = 5;
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
            this.headerCreditsLabel.TabIndex = 4;
            this.headerCreditsLabel.Text = "Yu-Gi-Oh Card Manager";
            this.headerCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerCreditsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerCreditsLabel_MouseMove);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.footerPanel.Controls.Add(this.versionLabel);
            this.footerPanel.Controls.Add(this.footerCreditLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(1, 504);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(518, 65);
            this.footerPanel.TabIndex = 1;
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
            this.versionLabel.TabIndex = 4;
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
            this.footerCreditLabel.TabIndex = 3;
            this.footerCreditLabel.Text = "Created By Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.fillPanel.Controls.Add(this.label1);
            this.fillPanel.Controls.Add(this.confermButton);
            this.fillPanel.Controls.Add(this.infoLoginButtonLabel);
            this.fillPanel.Controls.Add(this.title2Label);
            this.fillPanel.Controls.Add(this.titleLabel);
            this.fillPanel.Controls.Add(this.deckTextBox);
            this.fillPanel.Controls.Add(this.userLabel);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(1, 66);
            this.fillPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(518, 438);
            this.fillPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(233, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "(Full Name)";
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
            this.confermButton.Location = new System.Drawing.Point(205, 345);
            this.confermButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confermButton.Name = "confermButton";
            this.confermButton.Size = new System.Drawing.Size(100, 50);
            this.confermButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.confermButton.TabIndex = 20;
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
            this.infoLoginButtonLabel.Location = new System.Drawing.Point(112, 293);
            this.infoLoginButtonLabel.Name = "infoLoginButtonLabel";
            this.infoLoginButtonLabel.Size = new System.Drawing.Size(308, 23);
            this.infoLoginButtonLabel.TabIndex = 19;
            this.infoLoginButtonLabel.Text = "Press Enter or Press Button to Conferm";
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.title2Label.ForeColor = System.Drawing.Color.Gray;
            this.title2Label.Location = new System.Drawing.Point(180, 98);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(143, 37);
            this.title2Label.TabIndex = 17;
            this.title2Label.Text = "Insert New";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Gray;
            this.titleLabel.Location = new System.Drawing.Point(5, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 57);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Yu-Gi-Oh Card Manager";
            // 
            // deckTextBox
            // 
            this.deckTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deckTextBox.Location = new System.Drawing.Point(237, 208);
            this.deckTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deckTextBox.Name = "deckTextBox";
            this.deckTextBox.Size = new System.Drawing.Size(144, 27);
            this.deckTextBox.TabIndex = 14;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userLabel.ForeColor = System.Drawing.Color.Gray;
            this.userLabel.Location = new System.Drawing.Point(156, 212);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(52, 20);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "Name:";
            // 
            // AddDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 570);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDeckForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Deck";
            this.headerPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel fillPanel;
        private ReaLTaiizor.Controls.ParrotButton confermButton;
        private System.Windows.Forms.Label infoLoginButtonLabel;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.TextBox deckTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label headerCreditsLabel;
        private System.Windows.Forms.Button closeAllButton;
        private System.Windows.Forms.Label footerCreditLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
    }
}