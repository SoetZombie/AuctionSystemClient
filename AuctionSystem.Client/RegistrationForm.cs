using System;
using System.Windows.Forms;

namespace AuctionSystem.Client
{
    public partial class RegistrationForm : Form
    {
        private UserService.UserServiceClient client;
        private ZipServiceReference.ZipServiceClient zipClient;
        private  UserService.Gender gender;
        public RegistrationForm()
        {
            InitializeComponent();
            client = new UserService.UserServiceClient();
            zipClient = new ZipServiceReference.ZipServiceClient();
            gender = new UserService.Gender();
            dataGridView1.DataSource = zipClient.GetAllZips();
     
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var newUser = CreateNewUser();
            client.CreateUser(newUser);
            this.Close();
            
        }
        private UserService.User CreateNewUser()
        {
            if (femaleRadio.Checked)
            {
               gender = UserService.Gender.Female;
            }
            else if (maleRadio.Checked)
            {
                gender = UserService.Gender.Male;
            }
            else
            {
                throw new ArgumentException("specify gender");
            }

            return new UserService.User
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
