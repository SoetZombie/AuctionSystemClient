﻿using System;
using System.Windows.Forms;

namespace AuctionSystem.Client
{
    public partial class RegistrationForm : Form
    {
        UserServiceReference.UserServiceClient client;
        UserServiceReference.Gender gender;
        public RegistrationForm()
        {
            client = new UserServiceReference.UserServiceClient();
            InitializeComponent();
            gender = UserServiceReference.Gender.Male;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            var newUser = CreateNewUser();
            client.CreateUser(newUser);
            Login l = new Login();
            l.Show();
            this.Close();
            
        }
        private UserServiceReference.User CreateNewUser()
        {
            if (femaleRadio.Checked)
            {
               gender = UserServiceReference.Gender.Female;
            }
            else if (maleRadio.Checked)
            {
                gender = UserServiceReference.Gender.Male;
            }
            else
            {
                throw new ArgumentException("specify gender");
            }

            return new UserServiceReference.User
            {
                Username = usernameTxtBox.Text,
                Name = nameTxtBox.Text,
                DateOfBirth = DateTime.Parse(birthdateTxtBox.Text),
                Phone = phoneTxtBox.Text,
                Email = emailTxtBox.Text,
                Password = passwordTxtBox.Text,
                Gender = gender,
                IsAdmin = false,
                Coins = 0,
                ZipId = 1,
                Address = addressTxtBox.Text,
                IsDeleted = false,
                

            };
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

     

      


    }
}