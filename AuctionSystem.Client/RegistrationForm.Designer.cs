﻿namespace AuctionSystem.Client
{
    partial class RegistrationForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.ebidBtn = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.birthdateTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.zipIdTxtBox = new System.Windows.Forms.TextBox();
            this.zipIdLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DimGray;
            this.topPanel.Controls.Add(this.maximizeBtn);
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Controls.Add(this.ebidBtn);
            this.topPanel.Controls.Add(this.registrationLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1578, 102);
            this.topPanel.TabIndex = 10;
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackgroundImage = global::AuctionSystem.Client.Properties.Resources.expand;
            this.maximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximizeBtn.Location = new System.Drawing.Point(1502, 0);
            this.maximizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(35, 35);
            this.maximizeBtn.TabIndex = 7;
            this.maximizeBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.DimGray;
            this.exitBtn.BackgroundImage = global::AuctionSystem.Client.Properties.Resources.error__2_;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(1544, 0);
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
            this.ebidBtn.Size = new System.Drawing.Size(330, 102);
            this.ebidBtn.TabIndex = 4;
            this.ebidBtn.Text = "E-Bid";
            this.ebidBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ebidBtn.UseVisualStyleBackColor = false;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.registrationLabel.ForeColor = System.Drawing.Color.White;
            this.registrationLabel.Location = new System.Drawing.Point(583, 41);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(422, 58);
            this.registrationLabel.TabIndex = 16;
            this.registrationLabel.Text = "Register new user";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Century Gothic", 34F);
            this.loginLbl.ForeColor = System.Drawing.Color.White;
            this.loginLbl.Location = new System.Drawing.Point(305, -36);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(214, 83);
            this.loginLbl.TabIndex = 9;
            this.loginLbl.Text = "Login";
            // 
            // registerBtn
            // 
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerBtn.Image = global::AuctionSystem.Client.Properties.Resources.login;
            this.registerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerBtn.Location = new System.Drawing.Point(724, 705);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(292, 70);
            this.registerBtn.TabIndex = 15;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.phoneTxtBox.Location = new System.Drawing.Point(724, 302);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(263, 47);
            this.phoneTxtBox.TabIndex = 14;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.usernameTxtBox.Location = new System.Drawing.Point(724, 129);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(263, 47);
            this.usernameTxtBox.TabIndex = 13;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(343, 408);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(240, 58);
            this.passwordLbl.TabIndex = 12;
            this.passwordLbl.Text = "Password";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(343, 118);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(257, 58);
            this.usernameLbl.TabIndex = 11;
            this.usernameLbl.Text = "Username";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(343, 175);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(257, 58);
            this.nameLbl.TabIndex = 17;
            this.nameLbl.Text = "Full Name";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.birthdateLbl.ForeColor = System.Drawing.Color.White;
            this.birthdateLbl.Location = new System.Drawing.Point(343, 232);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(312, 58);
            this.birthdateLbl.TabIndex = 18;
            this.birthdateLbl.Text = "Date of birth";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.phoneLbl.ForeColor = System.Drawing.Color.White;
            this.phoneLbl.Location = new System.Drawing.Point(343, 291);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(374, 58);
            this.phoneLbl.TabIndex = 19;
            this.phoneLbl.Text = "Phone Number";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(343, 349);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(149, 58);
            this.emailLbl.TabIndex = 20;
            this.emailLbl.Text = "Email";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.genderLbl.ForeColor = System.Drawing.Color.White;
            this.genderLbl.Location = new System.Drawing.Point(344, 610);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(205, 58);
            this.genderLbl.TabIndex = 21;
            this.genderLbl.Text = "Gender";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.nameTxtBox.Location = new System.Drawing.Point(724, 188);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(263, 47);
            this.nameTxtBox.TabIndex = 22;
            // 
            // birthdateTxtBox
            // 
            this.birthdateTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.birthdateTxtBox.Location = new System.Drawing.Point(724, 245);
            this.birthdateTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthdateTxtBox.Name = "birthdateTxtBox";
            this.birthdateTxtBox.Size = new System.Drawing.Size(263, 47);
            this.birthdateTxtBox.TabIndex = 23;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.emailTxtBox.Location = new System.Drawing.Point(724, 361);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(263, 47);
            this.emailTxtBox.TabIndex = 24;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.passwordTxtBox.Location = new System.Drawing.Point(724, 419);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(263, 47);
            this.passwordTxtBox.TabIndex = 25;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.addressLbl.ForeColor = System.Drawing.Color.White;
            this.addressLbl.Location = new System.Drawing.Point(343, 466);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(209, 58);
            this.addressLbl.TabIndex = 26;
            this.addressLbl.Text = "Address";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.addressTxtBox.Location = new System.Drawing.Point(724, 478);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(263, 47);
            this.addressTxtBox.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Location = new System.Drawing.Point(724, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(263, 66);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.maleRadio.Location = new System.Drawing.Point(154, 20);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(100, 34);
            this.maleRadio.TabIndex = 1;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.femaleRadio.Location = new System.Drawing.Point(8, 20);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(124, 34);
            this.femaleRadio.TabIndex = 0;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // zipIdTxtBox
            // 
            this.zipIdTxtBox.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.zipIdTxtBox.Location = new System.Drawing.Point(726, 539);
            this.zipIdTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zipIdTxtBox.Name = "zipIdTxtBox";
            this.zipIdTxtBox.Size = new System.Drawing.Size(263, 47);
            this.zipIdTxtBox.TabIndex = 30;
            // 
            // zipIdLbl
            // 
            this.zipIdLbl.AutoSize = true;
            this.zipIdLbl.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.zipIdLbl.ForeColor = System.Drawing.Color.White;
            this.zipIdLbl.Location = new System.Drawing.Point(344, 528);
            this.zipIdLbl.Name = "zipIdLbl";
            this.zipIdLbl.Size = new System.Drawing.Size(147, 58);
            this.zipIdLbl.TabIndex = 29;
            this.zipIdLbl.Text = "Zip Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(994, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 224);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zipIdTxtBox);
            this.Controls.Add(this.zipIdLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.birthdateTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.birthdateLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button maximizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button ebidBtn;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox birthdateTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.TextBox zipIdTxtBox;
        private System.Windows.Forms.Label zipIdLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}