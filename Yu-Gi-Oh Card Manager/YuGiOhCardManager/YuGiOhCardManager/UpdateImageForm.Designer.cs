
namespace YuGiOhCardManager
{
    partial class UpdateImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateImageForm));
            this.fillPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.infoTimeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.updateImageButton = new ReaLTaiizor.Controls.ParrotButton();
            this.nrImageLabel = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.headerCreditsLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.fillPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.fillPanel.Controls.Add(this.label1);
            this.fillPanel.Controls.Add(this.infoTimeLabel);
            this.fillPanel.Controls.Add(this.timeLabel);
            this.fillPanel.Controls.Add(this.updateImageButton);
            this.fillPanel.Controls.Add(this.nrImageLabel);
            this.fillPanel.Controls.Add(this.title2Label);
            this.fillPanel.Controls.Add(this.titleLabel);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(1, 1);
            this.fillPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(683, 552);
            this.fillPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(233, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "You can\'t stop the Download";
            // 
            // infoTimeLabel
            // 
            this.infoTimeLabel.AutoSize = true;
            this.infoTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infoTimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.infoTimeLabel.Location = new System.Drawing.Point(152, 415);
            this.infoTimeLabel.Name = "infoTimeLabel";
            this.infoTimeLabel.Size = new System.Drawing.Size(346, 20);
            this.infoTimeLabel.TabIndex = 19;
            this.infoTimeLabel.Text = "A single image is downloaded in about 10 seconds";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeLabel.ForeColor = System.Drawing.Color.Gray;
            this.timeLabel.Location = new System.Drawing.Point(203, 288);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(92, 20);
            this.timeLabel.TabIndex = 18;
            this.timeLabel.Text = "0 sec to wait";
            // 
            // updateImageButton
            // 
            this.updateImageButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.updateImageButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("updateImageButton.ButtonImage")));
            this.updateImageButton.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.updateImageButton.ButtonText = "Download";
            this.updateImageButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.updateImageButton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.updateImageButton.CornerRadius = 5;
            this.updateImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateImageButton.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.updateImageButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.updateImageButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.updateImageButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.updateImageButton.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.updateImageButton.Location = new System.Drawing.Point(276, 351);
            this.updateImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateImageButton.Name = "updateImageButton";
            this.updateImageButton.Size = new System.Drawing.Size(109, 50);
            this.updateImageButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.updateImageButton.TabIndex = 17;
            this.updateImageButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.updateImageButton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.updateImageButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.updateImageButton.Click += new System.EventHandler(this.updateImageButton_Click);
            // 
            // nrImageLabel
            // 
            this.nrImageLabel.AutoSize = true;
            this.nrImageLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nrImageLabel.ForeColor = System.Drawing.Color.Gray;
            this.nrImageLabel.Location = new System.Drawing.Point(205, 250);
            this.nrImageLabel.Name = "nrImageLabel";
            this.nrImageLabel.Size = new System.Drawing.Size(217, 20);
            this.nrImageLabel.TabIndex = 13;
            this.nrImageLabel.Text = "You have 0 image to Download";
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.title2Label.ForeColor = System.Drawing.Color.Gray;
            this.title2Label.Location = new System.Drawing.Point(237, 171);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(186, 37);
            this.title2Label.TabIndex = 12;
            this.title2Label.Text = "Update Image";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Gray;
            this.titleLabel.Location = new System.Drawing.Point(95, 102);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 57);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Yu-Gi-Oh Card Manager";
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
            this.headerPanel.Size = new System.Drawing.Size(683, 65);
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
            this.closeAllButton.Location = new System.Drawing.Point(626, 0);
            this.closeAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(57, 65);
            this.closeAllButton.TabIndex = 4;
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
            this.headerCreditsLabel.Size = new System.Drawing.Size(683, 65);
            this.headerCreditsLabel.TabIndex = 3;
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
            this.footerPanel.Location = new System.Drawing.Point(1, 488);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(683, 65);
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
            this.footerCreditLabel.Size = new System.Drawing.Size(683, 65);
            this.footerCreditLabel.TabIndex = 2;
            this.footerCreditLabel.Text = "Created By Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 554);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.fillPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateImageForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Image";
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label footerCreditLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label headerCreditsLabel;
        private System.Windows.Forms.Button closeAllButton;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nrImageLabel;
        private System.Windows.Forms.Label timeLabel;
        private ReaLTaiizor.Controls.ParrotButton updateImageButton;
        private System.Windows.Forms.Label infoTimeLabel;
        private System.Windows.Forms.Label label1;
    }
}