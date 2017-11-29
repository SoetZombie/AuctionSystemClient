using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionSystem.Client
{
    public partial class DialogWindow : Form
    {
        public DialogWindow()
        {
            InitializeComponent();
        }
        public void SetErrorMsg(string errorMsg)
        {

            errorMsgLbl.Text = errorMsg;

        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
