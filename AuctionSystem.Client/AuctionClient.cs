using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;



namespace AuctionSystem.Client
{
    
    public partial class AuctionClient : Form
    {
        UserServiceReference.UserDto currentUser;
        UserServiceReference.User currentUser2;
        UserServiceReference.UserServiceClient client;
        string username;
        
        public AuctionClient()
        {
           
            client = new UserServiceReference.UserServiceClient();
            currentUser2 = new UserServiceReference.User();
            InitializeComponent();
           
        }
        public void CreateUserObject()
        {
            currentUser = client.GetUserById(1);
            currentUser2.Name = currentUser.Name;

        }

        public void UpdateUser()
        {
            CreateUserObject();
            client.UpdateUser(currentUser2, "name", "alois");
        }
       public void SetUsername(string usernamelog)
        {
            loggedasLbl.Text = "Logged as:  " + usernamelog;
            username = usernamelog;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private static bool Maximized = false;
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
        private void myaccountbtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = myaccountbtn.Height;
            selectionPanel.Top = myaccountbtn.Top;
        }

        private void newsBtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = newsBtn.Height;
            selectionPanel.Top = newsBtn.Top;
            //label1.Text = client.GetUserById(1).Name;
           // label1.Text = username;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void biddingBtn_Click(object sender, EventArgs e)
        {
            UpdateUser();
            selectionPanel.Height = biddingBtn.Height;
            selectionPanel.Top = biddingBtn.Top;
        }

        private void catalogueBtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = catalogueBtn.Height;
            selectionPanel.Top = catalogueBtn.Top;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = settingsBtn.Height;
            selectionPanel.Top = settingsBtn.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
