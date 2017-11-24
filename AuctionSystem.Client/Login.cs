
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private static bool Maximized = false;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxtBox.Text;
            //LoginController l = new Controllers.LoginController();
            
            if (client.ValidateLogin(usernameTxtBox.Text, passwordTxtBox.Text)) 
            // if (l.ValidateLogin(usernameTxtBox.Text, passwordTxtBox.Text))
            {
                
                AuctionClient a = new AuctionClient();
                // AuctionClient.username = usernameTxtBox.Text;
                
                a.Show();
                a.SetUsername(username);
                this.Close();

            }


        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
