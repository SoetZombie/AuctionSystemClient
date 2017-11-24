using System;
using System.Windows.Forms;

namespace AuctionSystem.Client
{
    public partial class RegistrationForm : Form
    {
        UserServiceReference.UserServiceClient client;
        public RegistrationForm()
        {
            client = new UserServiceReference.UserServiceClient();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var newUser = CreateNewUser();
            client.CreateUser(newUser);
            
        }
        private UserServiceReference.User CreateNewUser()
        {
            return new UserServiceReference.User
            {
                Username = usernameTxtBox.Text,
                Name = nameTxtBox.Text,
                DateOfBirth = DateTime.Parse(birthdateTxtBox.Text),
                Phone = phoneTxtBox.Text,
                Email = emailTxtBox.Text,
                Password = passwordTxtBox.Text,
                Gender = UserServiceReference.Gender.Female,
                IsAdmin = true,
                Coins = 0,
                Address = addressTxtBox.Text
            };
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
