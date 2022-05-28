
namespace YuGiOhCardManager
{
    partial class HomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.headerCreditsLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.title2Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.checkImageButton = new System.Windows.Forms.Button();
            this.MenuFormButton = new System.Windows.Forms.Button();
            this.testHandButton = new System.Windows.Forms.Button();
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
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1065, 65);
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
            this.closeAllButton.Location = new System.Drawing.Point(1008, 0);
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
            this.headerCreditsLabel.Size = new System.Drawing.Size(1065, 65);
            this.headerCreditsLabel.TabIndex = 2;
            this.headerCreditsLabel.Text = "Yu-Gi-Oh Card Manager";
            this.headerCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerCreditsLabel.Click += new System.EventHandler(this.headerCreditsLabel_Click);
            this.headerCreditsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerCreditsLabel_MouseMove);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.footerPanel.Controls.Add(this.versionLabel);
            this.footerPanel.Controls.Add(this.footerCreditLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(1, 488);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1065, 65);
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
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version 1.2";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footerCreditLabel
            // 
            this.footerCreditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerCreditLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.footerCreditLabel.ForeColor = System.Drawing.Color.Gray;
            this.footerCreditLabel.Location = new System.Drawing.Point(0, 0);
            this.footerCreditLabel.Name = "footerCreditLabel";
            this.footerCreditLabel.Size = new System.Drawing.Size(1065, 65);
            this.footerCreditLabel.TabIndex = 1;
            this.footerCreditLabel.Text = "Created By Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.fillPanel.Controls.Add(this.addNewUserButton);
            this.fillPanel.Controls.Add(this.title2Label);
            this.fillPanel.Controls.Add(this.titleLabel);
            this.fillPanel.Controls.Add(this.checkImageButton);
            this.fillPanel.Controls.Add(this.MenuFormButton);
            this.fillPanel.Controls.Add(this.testHandButton);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(1, 66);
            this.fillPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(1065, 422);
            this.fillPanel.TabIndex = 2;
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.FlatAppearance.BorderSize = 0;
            this.addNewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addNewUserButton.ForeColor = System.Drawing.Color.Gray;
            this.addNewUserButton.Location = new System.Drawing.Point(943, 50);
            this.addNewUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(107, 77);
            this.addNewUserButton.TabIndex = 11;
            this.addNewUserButton.Text = "Add New User";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.title2Label.ForeColor = System.Drawing.Color.Gray;
            this.title2Label.Location = new System.Drawing.Point(489, 102);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(89, 37);
            this.title2Label.TabIndex = 10;
            this.title2Label.Text = "Home";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Gray;
            this.titleLabel.Location = new System.Drawing.Point(277, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 57);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Yu-Gi-Oh Card Manager";
            // 
            // checkImageButton
            // 
            this.checkImageButton.FlatAppearance.BorderSize = 0;
            this.checkImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkImageButton.ForeColor = System.Drawing.Color.White;
            this.checkImageButton.Location = new System.Drawing.Point(749, 165);
            this.checkImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkImageButton.Name = "checkImageButton";
            this.checkImageButton.Size = new System.Drawing.Size(200, 185);
            this.checkImageButton.TabIndex = 2;
            this.checkImageButton.Text = "Check Update\r\nfor Local Image";
            this.checkImageButton.UseVisualStyleBackColor = true;
            this.checkImageButton.Click += new System.EventHandler(this.checkImageButton_Click);
            // 
            // MenuFormButton
            // 
            this.MenuFormButton.FlatAppearance.BorderSize = 0;
            this.MenuFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFormButton.ForeColor = System.Drawing.Color.White;
            this.MenuFormButton.Location = new System.Drawing.Point(433, 165);
            this.MenuFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuFormButton.Name = "MenuFormButton";
            this.MenuFormButton.Size = new System.Drawing.Size(200, 185);
            this.MenuFormButton.TabIndex = 1;
            this.MenuFormButton.Text = "Deck and Card Manager";
            this.MenuFormButton.UseVisualStyleBackColor = true;
            this.MenuFormButton.Click += new System.EventHandler(this.MenuFormButton_Click);
            // 
            // testHandButton
            // 
            this.testHandButton.FlatAppearance.BorderSize = 0;
            this.testHandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testHandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testHandButton.ForeColor = System.Drawing.Color.White;
            this.testHandButton.Location = new System.Drawing.Point(116, 165);
            this.testHandButton.Margin = new System.Windows.Forms.Padding(4);
            this.testHandButton.Name = "testHandButton";
            this.testHandButton.Size = new System.Drawing.Size(200, 185);
            this.testHandButton.TabIndex = 0;
            this.testHandButton.Text = "Test Hand";
            this.testHandButton.UseVisualStyleBackColor = true;
            this.testHandButton.Click += new System.EventHandler(this.testHandButton_Click);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeMenu";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
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
        private System.Windows.Forms.Label headerCreditsLabel;
        private System.Windows.Forms.Label footerCreditLabel;
        private System.Windows.Forms.Button closeAllButton;
        private System.Windows.Forms.Button MenuFormButton;
        private System.Windows.Forms.Button testHandButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button checkImageButton;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addNewUserButton;
    }
}