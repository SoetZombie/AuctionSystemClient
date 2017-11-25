using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AuctionSystem.Client
{
    using UserService;

    public partial class UserDataUserControll1 : UserControl
    {
        private UserServiceClient client;
        private UserDto currentUser;

        public UserDataUserControll1()
        {
            this.client = new UserServiceClient();
            this.currentUser = new UserDto();
            InitializeComponent();
            CreateObject();
            Setdata();
        }
        public void CreateObject()
        {
           currentUser = client.GetUserByUsername(AuctionClient.username);
        }
        public void Setdata()
        {
            usernameTxtBox.Text = currentUser.Username;
        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserDataUserControll1_Load(object sender, EventArgs e)
        {

        }
    }
}
