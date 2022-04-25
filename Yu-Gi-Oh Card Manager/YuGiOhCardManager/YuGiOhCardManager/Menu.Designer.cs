
namespace YuGiOhCardManager
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.resizeButton = new System.Windows.Forms.Button();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.headerCreditsLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.tabPage = new ReaLTaiizor.Controls.HopeTabPage();
            this.searchCardTabPage = new System.Windows.Forms.TabPage();
            this.searchCardDataGridView = new System.Windows.Forms.DataGridView();
            this.headerSearchCardHeaderPanel = new System.Windows.Forms.Panel();
            this.searchSearchCardTextBox = new System.Windows.Forms.TextBox();
            this.searchSearchCardLabel = new System.Windows.Forms.Label();
            this.wishlistTabPage = new System.Windows.Forms.TabPage();
            this.wishlistDataGridView = new System.Windows.Forms.DataGridView();
            this.wishlistHeaderPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myDeckTabPage = new System.Windows.Forms.TabPage();
            this.headerMyDeckHeaderPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seeDeckTabPage = new System.Windows.Forms.TabPage();
            this.headerSeeDeckHeaderPanel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDeckDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeDeckDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.fillPanel.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.searchCardTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCardDataGridView)).BeginInit();
            this.headerSearchCardHeaderPanel.SuspendLayout();
            this.wishlistTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishlistDataGridView)).BeginInit();
            this.wishlistHeaderPanel.SuspendLayout();
            this.myDeckTabPage.SuspendLayout();
            this.headerMyDeckHeaderPanel.SuspendLayout();
            this.seeDeckTabPage.SuspendLayout();
            this.headerSeeDeckHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDeckDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeDeckDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.minimizedButton);
            this.headerPanel.Controls.Add(this.resizeButton);
            this.headerPanel.Controls.Add(this.closeAllButton);
            this.headerPanel.Controls.Add(this.headerCreditsLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // minimizedButton
            // 
            this.minimizedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizedButton.FlatAppearance.BorderSize = 0;
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.minimizedButton.ForeColor = System.Drawing.Color.Gray;
            this.minimizedButton.Location = new System.Drawing.Point(829, 0);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(57, 60);
            this.minimizedButton.TabIndex = 4;
            this.minimizedButton.Text = "–";
            this.minimizedButton.UseVisualStyleBackColor = true;
            this.minimizedButton.Click += new System.EventHandler(this.minimizedButton_Click);
            // 
            // resizeButton
            // 
            this.resizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeButton.FlatAppearance.BorderSize = 0;
            this.resizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.resizeButton.ForeColor = System.Drawing.Color.Gray;
            this.resizeButton.Location = new System.Drawing.Point(886, 0);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(57, 60);
            this.resizeButton.TabIndex = 3;
            this.resizeButton.Text = "◻";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // closeAllButton
            // 
            this.closeAllButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAllButton.FlatAppearance.BorderSize = 0;
            this.closeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAllButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.closeAllButton.ForeColor = System.Drawing.Color.Gray;
            this.closeAllButton.Location = new System.Drawing.Point(943, 0);
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(57, 60);
            this.closeAllButton.TabIndex = 2;
            this.closeAllButton.Text = "❌";
            this.closeAllButton.UseVisualStyleBackColor = true;
            // 
            // headerCreditsLabel
            // 
            this.headerCreditsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerCreditsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.headerCreditsLabel.ForeColor = System.Drawing.Color.Gray;
            this.headerCreditsLabel.Location = new System.Drawing.Point(0, 0);
            this.headerCreditsLabel.Name = "headerCreditsLabel";
            this.headerCreditsLabel.Size = new System.Drawing.Size(1000, 60);
            this.headerCreditsLabel.TabIndex = 1;
            this.headerCreditsLabel.Text = "Yu-Gi-Oh Card Manager";
            this.headerCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerCreditsLabel.DoubleClick += new System.EventHandler(this.resizeButton_Click);
            this.headerCreditsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerCreditsLabel_MouseMove);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.footerCreditLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 485);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1000, 65);
            this.footerPanel.TabIndex = 1;
            // 
            // footerCreditLabel
            // 
            this.footerCreditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerCreditLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.footerCreditLabel.ForeColor = System.Drawing.Color.Gray;
            this.footerCreditLabel.Location = new System.Drawing.Point(0, 0);
            this.footerCreditLabel.Name = "footerCreditLabel";
            this.footerCreditLabel.Size = new System.Drawing.Size(1000, 65);
            this.footerCreditLabel.TabIndex = 0;
            this.footerCreditLabel.Text = "Created By Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.tabPage);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 60);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(1000, 425);
            this.fillPanel.TabIndex = 2;
            // 
            // tabPage
            // 
            this.tabPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tabPage.Controls.Add(this.searchCardTabPage);
            this.tabPage.Controls.Add(this.wishlistTabPage);
            this.tabPage.Controls.Add(this.myDeckTabPage);
            this.tabPage.Controls.Add(this.seeDeckTabPage);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPage.ForeColorA = System.Drawing.Color.White;
            this.tabPage.ForeColorB = System.Drawing.Color.Silver;
            this.tabPage.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage.ItemSize = new System.Drawing.Size(120, 45);
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1000, 425);
            this.tabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage.TabIndex = 2;
            this.tabPage.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPage.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPage.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // searchCardTabPage
            // 
            this.searchCardTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.searchCardTabPage.Controls.Add(this.searchCardDataGridView);
            this.searchCardTabPage.Controls.Add(this.headerSearchCardHeaderPanel);
            this.searchCardTabPage.ForeColor = System.Drawing.Color.White;
            this.searchCardTabPage.Location = new System.Drawing.Point(0, 45);
            this.searchCardTabPage.Name = "searchCardTabPage";
            this.searchCardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchCardTabPage.Size = new System.Drawing.Size(1000, 380);
            this.searchCardTabPage.TabIndex = 0;
            this.searchCardTabPage.Text = "Search Card";
            // 
            // searchCardDataGridView
            // 
            this.searchCardDataGridView.AllowUserToDeleteRows = false;
            this.searchCardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.searchCardDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCardDataGridView.Location = new System.Drawing.Point(3, 59);
            this.searchCardDataGridView.Name = "searchCardDataGridView";
            this.searchCardDataGridView.ReadOnly = true;
            this.searchCardDataGridView.RowHeadersWidth = 51;
            this.searchCardDataGridView.RowTemplate.Height = 50;
            this.searchCardDataGridView.Size = new System.Drawing.Size(994, 318);
            this.searchCardDataGridView.TabIndex = 1;
            // 
            // headerSearchCardHeaderPanel
            // 
            this.headerSearchCardHeaderPanel.Controls.Add(this.searchSearchCardTextBox);
            this.headerSearchCardHeaderPanel.Controls.Add(this.searchSearchCardLabel);
            this.headerSearchCardHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSearchCardHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.headerSearchCardHeaderPanel.Name = "headerSearchCardHeaderPanel";
            this.headerSearchCardHeaderPanel.Size = new System.Drawing.Size(994, 56);
            this.headerSearchCardHeaderPanel.TabIndex = 0;
            // 
            // searchSearchCardTextBox
            // 
            this.searchSearchCardTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchSearchCardTextBox.Location = new System.Drawing.Point(80, 15);
            this.searchSearchCardTextBox.Name = "searchSearchCardTextBox";
            this.searchSearchCardTextBox.Size = new System.Drawing.Size(144, 27);
            this.searchSearchCardTextBox.TabIndex = 12;
            this.searchSearchCardTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchSearchCardLabel
            // 
            this.searchSearchCardLabel.AutoSize = true;
            this.searchSearchCardLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchSearchCardLabel.ForeColor = System.Drawing.Color.Gray;
            this.searchSearchCardLabel.Location = new System.Drawing.Point(12, 18);
            this.searchSearchCardLabel.Name = "searchSearchCardLabel";
            this.searchSearchCardLabel.Size = new System.Drawing.Size(56, 20);
            this.searchSearchCardLabel.TabIndex = 11;
            this.searchSearchCardLabel.Text = "Search:";
            // 
            // wishlistTabPage
            // 
            this.wishlistTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.wishlistTabPage.Controls.Add(this.wishlistDataGridView);
            this.wishlistTabPage.Controls.Add(this.wishlistHeaderPanel);
            this.wishlistTabPage.ForeColor = System.Drawing.Color.White;
            this.wishlistTabPage.Location = new System.Drawing.Point(0, 45);
            this.wishlistTabPage.Name = "wishlistTabPage";
            this.wishlistTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wishlistTabPage.Size = new System.Drawing.Size(1000, 380);
            this.wishlistTabPage.TabIndex = 1;
            this.wishlistTabPage.Text = "Wishlist";
            // 
            // wishlistDataGridView
            // 
            this.wishlistDataGridView.AllowUserToDeleteRows = false;
            this.wishlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishlistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9});
            this.wishlistDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlistDataGridView.Location = new System.Drawing.Point(3, 59);
            this.wishlistDataGridView.Name = "wishlistDataGridView";
            this.wishlistDataGridView.ReadOnly = true;
            this.wishlistDataGridView.RowHeadersWidth = 51;
            this.wishlistDataGridView.RowTemplate.Height = 50;
            this.wishlistDataGridView.Size = new System.Drawing.Size(994, 318);
            this.wishlistDataGridView.TabIndex = 2;
            // 
            // wishlistHeaderPanel
            // 
            this.wishlistHeaderPanel.Controls.Add(this.textBox1);
            this.wishlistHeaderPanel.Controls.Add(this.label1);
            this.wishlistHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wishlistHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.wishlistHeaderPanel.Name = "wishlistHeaderPanel";
            this.wishlistHeaderPanel.Size = new System.Drawing.Size(994, 56);
            this.wishlistHeaderPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(77, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 27);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // myDeckTabPage
            // 
            this.myDeckTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.myDeckTabPage.Controls.Add(this.myDeckDataGridView);
            this.myDeckTabPage.Controls.Add(this.headerMyDeckHeaderPanel);
            this.myDeckTabPage.ForeColor = System.Drawing.Color.White;
            this.myDeckTabPage.Location = new System.Drawing.Point(0, 45);
            this.myDeckTabPage.Name = "myDeckTabPage";
            this.myDeckTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myDeckTabPage.Size = new System.Drawing.Size(1000, 380);
            this.myDeckTabPage.TabIndex = 2;
            this.myDeckTabPage.Text = "My Deck";
            // 
            // headerMyDeckHeaderPanel
            // 
            this.headerMyDeckHeaderPanel.Controls.Add(this.textBox2);
            this.headerMyDeckHeaderPanel.Controls.Add(this.label2);
            this.headerMyDeckHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerMyDeckHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.headerMyDeckHeaderPanel.Name = "headerMyDeckHeaderPanel";
            this.headerMyDeckHeaderPanel.Size = new System.Drawing.Size(994, 56);
            this.headerMyDeckHeaderPanel.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(77, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 27);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search:";
            // 
            // seeDeckTabPage
            // 
            this.seeDeckTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.seeDeckTabPage.Controls.Add(this.seeDeckDataGridView);
            this.seeDeckTabPage.Controls.Add(this.headerSeeDeckHeaderPanel);
            this.seeDeckTabPage.ForeColor = System.Drawing.Color.White;
            this.seeDeckTabPage.Location = new System.Drawing.Point(0, 45);
            this.seeDeckTabPage.Name = "seeDeckTabPage";
            this.seeDeckTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.seeDeckTabPage.Size = new System.Drawing.Size(1000, 380);
            this.seeDeckTabPage.TabIndex = 4;
            this.seeDeckTabPage.Text = "See Deck";
            // 
            // headerSeeDeckHeaderPanel
            // 
            this.headerSeeDeckHeaderPanel.Controls.Add(this.textBox4);
            this.headerSeeDeckHeaderPanel.Controls.Add(this.label4);
            this.headerSeeDeckHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSeeDeckHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.headerSeeDeckHeaderPanel.Name = "headerSeeDeckHeaderPanel";
            this.headerSeeDeckHeaderPanel.Size = new System.Drawing.Size(994, 56);
            this.headerSeeDeckHeaderPanel.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox4.Location = new System.Drawing.Point(77, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 27);
            this.textBox4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Search:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Card";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Attr";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Level";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Atk";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Def";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Effect";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Price";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nr Copies";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // myDeckDataGridView
            // 
            this.myDeckDataGridView.AllowUserToDeleteRows = false;
            this.myDeckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDeckDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column10,
            this.dataGridViewTextBoxColumn5});
            this.myDeckDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDeckDataGridView.Location = new System.Drawing.Point(3, 59);
            this.myDeckDataGridView.Name = "myDeckDataGridView";
            this.myDeckDataGridView.ReadOnly = true;
            this.myDeckDataGridView.RowHeadersWidth = 51;
            this.myDeckDataGridView.RowTemplate.Height = 50;
            this.myDeckDataGridView.Size = new System.Drawing.Size(994, 318);
            this.myDeckDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tot Card";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Carte Mancanti";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // seeDeckDataGridView
            // 
            this.seeDeckDataGridView.AllowUserToDeleteRows = false;
            this.seeDeckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seeDeckDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.seeDeckDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seeDeckDataGridView.Location = new System.Drawing.Point(3, 59);
            this.seeDeckDataGridView.Name = "seeDeckDataGridView";
            this.seeDeckDataGridView.ReadOnly = true;
            this.seeDeckDataGridView.RowHeadersWidth = 51;
            this.seeDeckDataGridView.RowTemplate.Height = 50;
            this.seeDeckDataGridView.Size = new System.Drawing.Size(994, 318);
            this.seeDeckDataGridView.TabIndex = 3;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "Image";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.HeaderText = "Nr Copies";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.headerPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.fillPanel.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.searchCardTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchCardDataGridView)).EndInit();
            this.headerSearchCardHeaderPanel.ResumeLayout(false);
            this.headerSearchCardHeaderPanel.PerformLayout();
            this.wishlistTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wishlistDataGridView)).EndInit();
            this.wishlistHeaderPanel.ResumeLayout(false);
            this.wishlistHeaderPanel.PerformLayout();
            this.myDeckTabPage.ResumeLayout(false);
            this.headerMyDeckHeaderPanel.ResumeLayout(false);
            this.headerMyDeckHeaderPanel.PerformLayout();
            this.seeDeckTabPage.ResumeLayout(false);
            this.headerSeeDeckHeaderPanel.ResumeLayout(false);
            this.headerSeeDeckHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDeckDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeDeckDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeAllButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label footerCreditLabel;
        private System.Windows.Forms.Panel fillPanel;
        private ReaLTaiizor.Controls.HopeTabPage tabPage;
        private System.Windows.Forms.TabPage searchCardTabPage;
        private System.Windows.Forms.TabPage wishlistTabPage;
        private System.Windows.Forms.Label headerCreditsLabel;
        private System.Windows.Forms.TabPage myDeckTabPage;
        private System.Windows.Forms.TabPage seeDeckTabPage;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Panel headerSearchCardHeaderPanel;
        private System.Windows.Forms.Panel wishlistHeaderPanel;
        private System.Windows.Forms.Panel headerMyDeckHeaderPanel;
        private System.Windows.Forms.Panel headerSeeDeckHeaderPanel;
        private System.Windows.Forms.DataGridView searchCardDataGridView;
        private System.Windows.Forms.TextBox searchSearchCardTextBox;
        private System.Windows.Forms.Label searchSearchCardLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView wishlistDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView myDeckDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView seeDeckDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}