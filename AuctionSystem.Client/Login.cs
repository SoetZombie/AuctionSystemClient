
using System;
using System.Windows.Forms;

namespace AuctionSystem.Client
{
   
    public partial class Login : Form
    {
       
        LoginServiceReference.LoginServiceClient client;
        public Login()
        {
            InitializeComponent();
            client = new LoginServiceReference.LoginServiceClient();
        }

        private static bool Maximized = false;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxtBox.Text;
            if (client.ValidateLogin(usernameTxtBox.Text, passwordTxtBox.Text)) 
            {
                AuctionClient a = new AuctionClient();
                a.Show();
                a.SetUsername(username);
                this.Close();
            }


        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (Maximized)
            {
                WindowState = FormWindowState.Normal;
                Maximized = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                Maximized = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm r = new RegistrationForm();
            r.ShowDialog();
        }

      
    }
}
