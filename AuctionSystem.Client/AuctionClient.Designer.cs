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
            this.loggedAsLbl = new System.Windows.Forms.Label();
            this.loggedasUsernameLbl = new System.Windows.Forms.Label();
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
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.myAccountPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.myAccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DimGray;
            this.topPanel.Controls.Add(this.loggedAsLbl);
            this.topPanel.Controls.Add(this.loggedasUsernameLbl);
            this.topPanel.Controls.Add(this.maximizeBtn);
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(293, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1110, 82);
            this.topPanel.TabIndex = 5;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);

            // 
            // loggedAsLbl
            // 
            this.loggedAsLbl.AutoSize = true;
            this.loggedAsLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.loggedAsLbl.Location = new System.Drawing.Point(653, 0);
            this.loggedAsLbl.Name = "loggedAsLbl";
            this.loggedAsLbl.Size = new System.Drawing.Size(156, 28);
            this.loggedAsLbl.TabIndex = 8;
            this.loggedAsLbl.Text = "Logged as : ";
            // 
            // loggedasUsernameLbl
            // 
            this.loggedasUsernameLbl.AutoSize = true;
            this.loggedasUsernameLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedasUsernameLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.loggedasUsernameLbl.Location = new System.Drawing.Point(825, 0);
            this.loggedasUsernameLbl.Name = "loggedasUsernameLbl";
            this.loggedasUsernameLbl.Size = new System.Drawing.Size(149, 28);
            this.loggedasUsernameLbl.TabIndex = 7;
            this.loggedasUsernameLbl.Text = "Logged as :";
            this.loggedasUsernameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackgroundImage = global::AuctionSystem.Client.Properties.Resources.expand;
            this.maximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximizeBtn.Location = new System.Drawing.Point(1043, 0);
            this.maximizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(31, 28);
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
            this.exitBtn.Location = new System.Drawing.Point(1079, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(31, 28);
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
            this.ebidBtn.Size = new System.Drawing.Size(587, 82);
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
            this.leftMenuPanel.Size = new System.Drawing.Size(293, 675);
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
            this.logoutBtn.Location = new System.Drawing.Point(20, 522);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(270, 69);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectionPanel
            // 
            this.selectionPanel.BackColor = System.Drawing.Color.DimGray;
            this.selectionPanel.Location = new System.Drawing.Point(3, 130);
            this.selectionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(15, 69);
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
            this.newsBtn.Location = new System.Drawing.Point(20, 130);
            this.newsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newsBtn.Name = "newsBtn";
            this.newsBtn.Size = new System.Drawing.Size(270, 69);
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
            this.settingsBtn.Location = new System.Drawing.Point(20, 604);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(270, 69);
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
            this.myaccountbtn.Location = new System.Drawing.Point(20, 354);
            this.myaccountbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myaccountbtn.Name = "myaccountbtn";
            this.myaccountbtn.Size = new System.Drawing.Size(270, 69);
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
            this.catalogueBtn.Location = new System.Drawing.Point(20, 281);
            this.catalogueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalogueBtn.Name = "catalogueBtn";
            this.catalogueBtn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.catalogueBtn.Size = new System.Drawing.Size(270, 69);
            this.catalogueBtn.TabIndex = 6;
            this.catalogueBtn.Text = "    Catalog";
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
            this.biddingBtn.Location = new System.Drawing.Point(20, 203);
            this.biddingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.biddingBtn.Name = "biddingBtn";
            this.biddingBtn.Size = new System.Drawing.Size(270, 69);
            this.biddingBtn.TabIndex = 5;
            this.biddingBtn.Text = "   Bidding";
            this.biddingBtn.UseVisualStyleBackColor = true;
            this.biddingBtn.Click += new System.EventHandler(this.biddingBtn_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.usernameTxtBox.Location = new System.Drawing.Point(283, 35);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(167, 40);
            this.usernameTxtBox.TabIndex = 54;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.usernameLbl.ForeColor = System.Drawing.Color.Black;
            this.usernameLbl.Location = new System.Drawing.Point(29, 35);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(146, 33);
            this.usernameLbl.TabIndex = 55;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.passwordLbl.ForeColor = System.Drawing.Color.Black;
            this.passwordLbl.Location = new System.Drawing.Point(29, 267);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(138, 33);
            this.passwordLbl.TabIndex = 56;
            this.passwordLbl.Text = "Password";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.nameLbl.ForeColor = System.Drawing.Color.Black;
            this.nameLbl.Location = new System.Drawing.Point(29, 81);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(145, 33);
            this.nameLbl.TabIndex = 57;
            this.nameLbl.Text = "Full Name";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.birthdateLbl.ForeColor = System.Drawing.Color.Black;
            this.birthdateLbl.Location = new System.Drawing.Point(29, 127);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(179, 33);
            this.birthdateLbl.TabIndex = 58;
            this.birthdateLbl.Text = "Date of birth";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.phoneLbl.ForeColor = System.Drawing.Color.Black;
            this.phoneLbl.Location = new System.Drawing.Point(29, 174);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(212, 33);
            this.phoneLbl.TabIndex = 59;
            this.phoneLbl.Text = "Phone Number";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.emailLbl.ForeColor = System.Drawing.Color.Black;
            this.emailLbl.Location = new System.Drawing.Point(29, 220);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(85, 33);
            this.emailLbl.TabIndex = 60;
            this.emailLbl.Text = "Email";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.addressLbl.ForeColor = System.Drawing.Color.Black;
            this.addressLbl.Location = new System.Drawing.Point(29, 314);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(118, 33);
            this.addressLbl.TabIndex = 61;
            this.addressLbl.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox2.Location = new System.Drawing.Point(283, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 40);
            this.textBox2.TabIndex = 62;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox3.Location = new System.Drawing.Point(283, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 40);
            this.textBox3.TabIndex = 63;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox4.Location = new System.Drawing.Point(283, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 40);
            this.textBox4.TabIndex = 64;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox5.Location = new System.Drawing.Point(283, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 40);
            this.textBox5.TabIndex = 65;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox6.Location = new System.Drawing.Point(283, 266);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 40);
            this.textBox6.TabIndex = 66;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox7.Location = new System.Drawing.Point(283, 314);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(167, 40);
            this.textBox7.TabIndex = 67;
            // 
            // myAccountPanel
            // 
            this.myAccountPanel.Controls.Add(this.textBox7);
            this.myAccountPanel.Controls.Add(this.textBox6);
            this.myAccountPanel.Controls.Add(this.textBox5);
            this.myAccountPanel.Controls.Add(this.textBox4);
            this.myAccountPanel.Controls.Add(this.textBox3);
            this.myAccountPanel.Controls.Add(this.textBox2);
            this.myAccountPanel.Controls.Add(this.addressLbl);
            this.myAccountPanel.Controls.Add(this.emailLbl);
            this.myAccountPanel.Controls.Add(this.phoneLbl);
            this.myAccountPanel.Controls.Add(this.birthdateLbl);
            this.myAccountPanel.Controls.Add(this.nameLbl);
            this.myAccountPanel.Controls.Add(this.passwordLbl);
            this.myAccountPanel.Controls.Add(this.usernameLbl);
            this.myAccountPanel.Controls.Add(this.usernameTxtBox);
            this.myAccountPanel.Location = new System.Drawing.Point(299, 87);
            this.myAccountPanel.Name = "myAccountPanel";
            this.myAccountPanel.Size = new System.Drawing.Size(822, 533);
            this.myAccountPanel.TabIndex = 7;
            this.myAccountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.myAccountPanel_Paint);
            // 
            // AuctionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 675);
            this.Controls.Add(this.myAccountPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuctionClient";
            this.Text = "AuctionClient";
            this.Load += new System.EventHandler(this.AuctionClient_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftMenuPanel.ResumeLayout(false);
            this.myAccountPanel.ResumeLayout(false);
            this.myAccountPanel.PerformLayout();
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
        private System.Windows.Forms.Label loggedasUsernameLbl;
        private System.Windows.Forms.Label loggedAsLbl;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel myAccountPanel;
    }
}