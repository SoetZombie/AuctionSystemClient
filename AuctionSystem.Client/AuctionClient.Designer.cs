namespace AuctionSystem.Client
{
    partial class AuctionClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionClient));
            this.topPanel = new System.Windows.Forms.Panel();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.ebidBtn = new System.Windows.Forms.Button();
            this.leftMenuPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.newsBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.myaccountbtn = new System.Windows.Forms.Button();
            this.catalogueBtn = new System.Windows.Forms.Button();
            this.biddingBtn = new System.Windows.Forms.Button();
            this.loggedasLbl = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DimGray;
            this.topPanel.Controls.Add(this.loggedasLbl);
            this.topPanel.Controls.Add(this.maximizeBtn);
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(330, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1248, 102);
            this.topPanel.TabIndex = 5;
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackgroundImage = global::AuctionSystem.Client.Properties.Resources.expand;
            this.maximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximizeBtn.Location = new System.Drawing.Point(1172, 0);
            this.maximizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(35, 35);
            this.maximizeBtn.TabIndex = 7;
            this.maximizeBtn.UseVisualStyleBackColor = true;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.DimGray;
            this.exitBtn.BackgroundImage = global::AuctionSystem.Client.Properties.Resources.error__2_;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(1213, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 35);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ebidBtn
            // 
            this.ebidBtn.BackColor = System.Drawing.Color.DimGray;
            this.ebidBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ebidBtn.FlatAppearance.BorderSize = 0;
            this.ebidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ebidBtn.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebidBtn.ForeColor = System.Drawing.Color.Black;
            this.ebidBtn.Location = new System.Drawing.Point(0, 0);
            this.ebidBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ebidBtn.Name = "ebidBtn";
            this.ebidBtn.Size = new System.Drawing.Size(660, 102);
            this.ebidBtn.TabIndex = 4;
            this.ebidBtn.Text = "E-Bid";
            this.ebidBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ebidBtn.UseVisualStyleBackColor = false;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.leftMenuPanel.Controls.Add(this.logoutBtn);
            this.leftMenuPanel.Controls.Add(this.ebidBtn);
            this.leftMenuPanel.Controls.Add(this.selectionPanel);
            this.leftMenuPanel.Controls.Add(this.newsBtn);
            this.leftMenuPanel.Controls.Add(this.settingsBtn);
            this.leftMenuPanel.Controls.Add(this.myaccountbtn);
            this.leftMenuPanel.Controls.Add(this.catalogueBtn);
            this.leftMenuPanel.Controls.Add(this.biddingBtn);
            this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftMenuPanel.Name = "leftMenuPanel";
            this.leftMenuPanel.Size = new System.Drawing.Size(330, 844);
            this.leftMenuPanel.TabIndex = 6;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(22, 652);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(304, 86);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectionPanel
            // 
            this.selectionPanel.BackColor = System.Drawing.Color.DimGray;
            this.selectionPanel.Location = new System.Drawing.Point(3, 162);
            this.selectionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(17, 86);
            this.selectionPanel.TabIndex = 5;
            // 
            // newsBtn
            // 
            this.newsBtn.FlatAppearance.BorderSize = 0;
            this.newsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newsBtn.Image = global::AuctionSystem.Client.Properties.Resources.news_icon_136481;
            this.newsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newsBtn.Location = new System.Drawing.Point(22, 162);
            this.newsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newsBtn.Name = "newsBtn";
            this.newsBtn.Size = new System.Drawing.Size(304, 86);
            this.newsBtn.TabIndex = 9;
            this.newsBtn.Text = "News";
            this.newsBtn.UseVisualStyleBackColor = true;
            this.newsBtn.Click += new System.EventHandler(this.newsBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsBtn.Image = global::AuctionSystem.Client.Properties.Resources.settings_icon_14953;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(22, 755);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(304, 86);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.Text = "    Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // myaccountbtn
            // 
            this.myaccountbtn.FlatAppearance.BorderSize = 0;
            this.myaccountbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myaccountbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.myaccountbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myaccountbtn.Image = global::AuctionSystem.Client.Properties.Resources.account_icon_25499;
            this.myaccountbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myaccountbtn.Location = new System.Drawing.Point(22, 442);
            this.myaccountbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myaccountbtn.Name = "myaccountbtn";
            this.myaccountbtn.Size = new System.Drawing.Size(304, 86);
            this.myaccountbtn.TabIndex = 7;
            this.myaccountbtn.Text = "          My account";
            this.myaccountbtn.UseVisualStyleBackColor = true;
            this.myaccountbtn.Click += new System.EventHandler(this.myaccountbtn_Click);
            // 
            // catalogueBtn
            // 
            this.catalogueBtn.FlatAppearance.BorderSize = 0;
            this.catalogueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogueBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.catalogueBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.catalogueBtn.Image = global::AuctionSystem.Client.Properties.Resources.catalog;
            this.catalogueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogueBtn.Location = new System.Drawing.Point(22, 351);
            this.catalogueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalogueBtn.Name = "catalogueBtn";
            this.catalogueBtn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.catalogueBtn.Size = new System.Drawing.Size(304, 86);
            this.catalogueBtn.TabIndex = 6;
            this.catalogueBtn.Text = "   Catalog";
            this.catalogueBtn.UseVisualStyleBackColor = true;
            this.catalogueBtn.Click += new System.EventHandler(this.catalogueBtn_Click);
            // 
            // biddingBtn
            // 
            this.biddingBtn.FlatAppearance.BorderSize = 0;
            this.biddingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biddingBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.biddingBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.biddingBtn.Image = global::AuctionSystem.Client.Properties.Resources.auction_icon_16281;
            this.biddingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biddingBtn.Location = new System.Drawing.Point(22, 254);
            this.biddingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.biddingBtn.Name = "biddingBtn";
            this.biddingBtn.Size = new System.Drawing.Size(304, 86);
            this.biddingBtn.TabIndex = 5;
            this.biddingBtn.Text = "   Bidding";
            this.biddingBtn.UseVisualStyleBackColor = true;
            this.biddingBtn.Click += new System.EventHandler(this.biddingBtn_Click);
            // 
            // loggedasLbl
            // 
            this.loggedasLbl.AutoSize = true;
            this.loggedasLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedasLbl.Location = new System.Drawing.Point(739, 5);
            this.loggedasLbl.Name = "loggedasLbl";
            this.loggedasLbl.Size = new System.Drawing.Size(151, 30);
            this.loggedasLbl.TabIndex = 7;
            this.loggedasLbl.Text = "Logged as :";
            this.loggedasLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // AuctionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuctionClient";
            this.Text = "AuctionClient";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button maximizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button ebidBtn;
        private System.Windows.Forms.Panel leftMenuPanel;
        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.Button newsBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button myaccountbtn;
        private System.Windows.Forms.Button catalogueBtn;
        private System.Windows.Forms.Button biddingBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label loggedasLbl;
    }
}