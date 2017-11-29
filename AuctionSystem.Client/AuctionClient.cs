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
        private UserService.UserDto currentUser;
        private UserService.UserServiceClient userClient;
        private PaymentServiceReference.PaymentServiceClient paymentClient;
        private BidService.IBidService bidService;
        private ProductService.IProductService productService;
        private ZipServiceReference.IZipService zipService;

        public static string username;
        public static string password;

        public AuctionClient()
        {
            this.productService = new ProductService.ProductServiceClient();
            this.bidService = new BidService.BidServiceClient();
            this.userClient = new UserService.UserServiceClient();
            this.zipService = new ZipServiceReference.ZipServiceClient();
            paymentClient = new PaymentServiceReference.PaymentServiceClient();
            InitializeComponent();
            myAccountPanel.Hide();

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
        public void GetUserObject()
        {
            currentUser = userClient.GetUserByUsername(username);
            currentUser.Password = password;
        }

        public void setUsernameAndPw(string usernamelog, string passwordlog)
        {
            username = usernamelog;
            password = passwordlog;
            GetUserObject();
            loggedasUsernameLbl.Text = username;
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
            SetUserData();
            
            myAccountPanel.Show();
            
        }
        private void SetUserData()
        {
            selectionPanel.Height = myaccountbtn.Height;
            selectionPanel.Top = myaccountbtn.Top;
            myAccountPanel.BringToFront();
            usernameTxtBox.Text = currentUser.Username;
            passwordTxtBox.Text = currentUser.Password;
            nameTxtBox.Text = currentUser.Name;
            birthdateTxtBox.Text = currentUser.DateOfBirth.ToString();
            emailTxtBox.Text = currentUser.Email;
            addressTxtbox.Text = currentUser.Address;
            phoneNumberTxtBox.Text = currentUser.Phone;
            zipTxtBox.Text = currentUser.ZipId.ToString();
            currentCoinsTxtBox.Text = currentUser.Coins.ToString();
            currentpaymentlbl.Text = currentUser.Payments;
            zipsGrid.DataSource = zipService.GetAllZips();

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

        private void userDataUserControll1_Load(object sender, EventArgs e)
        {

        }

        private void userDataUserControll11_Load(object sender, EventArgs e)
        {

        }

        private void AuctionClient_Load(object sender, EventArgs e)
        {

        }

        private void myAccountPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void saveNewPaymentBtn_Click(object sender, EventArgs e)
        {
            if (!currentUser.Payments.Any()) { paymentClient.AddPayment(CreatePaymentObject(), currentUser.Id); }
            currentUser = userClient.GetUserByUsername(currentUser.Username);
        }

        private PaymentServiceReference.Payment CreatePaymentObject()
        {
            PaymentServiceReference.PaymentType paymentType = new PaymentServiceReference.PaymentType();
            if (paypalRadioBtn.Checked) { paymentType = PaymentServiceReference.PaymentType.PayPal; }
            else if (creditCardRadioBtn.Checked) { paymentType = PaymentServiceReference.PaymentType.CreditCard; }
            else if (banktransferRadioBtn.Checked) { paymentType = PaymentServiceReference.PaymentType.BankTransfer; }
            return new PaymentServiceReference.Payment
            {
                Type = paymentType,
                PaymentTypeCode = paymentTypeCodeTxtBox.Text,
                UserId = currentUser.Id,

            };
        }

        private void GetBidBtn_Click(object sender, EventArgs e)
        {
            var bidDtoArray = this.bidService.GetAllBidsByUserId(4); // take the current logged user id which in our case is 4 because login option is off for now!

            var sb = new StringBuilder();

            foreach (var item in bidDtoArray)
            {
                sb.AppendLine($"Product: {item.ProductName}");
                sb.AppendLine($"Username: {item.Username}");
                sb.AppendLine($"Date of creation: {item.DateOfCreated.ToString()}");
                sb.AppendLine($"Coins: {item.Coins.ToString()}");
                sb.AppendLine($"Is won: {item.IsWon.ToString()}");
                sb.AppendLine("----------------");
            }

            ResultTextBox.Text = sb.ToString(); 
        }

        // Take a look here !
        private void MakeBidBtn_Click(object sender, EventArgs e)
        {
            var productName = ProductTextBox.Text;
            var productId = this.productService.GetProductByName(productName).Id;

           // var userId = this.userClient.GetUserByUsername("gosho").Id;

            var coins = int.Parse(CoinsTextBox.Text);

            //this.bidService.MakeBid(userId, productId, coins);
        }

        private void GetProductBids_Click(object sender, EventArgs e)
        {
            var productName = SearchProductTextBox.Text;
            var bidDtoArray = this.bidService.GetAllBidsByProductName(productName);

            var sb = new StringBuilder();

            foreach (var item in bidDtoArray)
            {
                sb.AppendLine($"Product: {item.ProductName}");
                sb.AppendLine($"Username: {item.Username}");
                sb.AppendLine($"Date of creation: {item.DateOfCreated.ToString()}");
                sb.AppendLine($"Coins: {item.Coins.ToString()}");
                sb.AppendLine($"Is won: {item.IsWon.ToString()}");
                sb.AppendLine("----------------");
            }

            ResultTextBox.Text = sb.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateExistingPaymentBtn_Click(object sender, EventArgs e)
        {
            if (currentUser.PaymentId == "")
            {
                paymentClient.AddPayment(CreatePaymentObject(), currentUser.Id);
                GetUserObject();
                SetUserData();
            }
            else
            {
                var currentpayment = paymentClient.GetPayment(int.Parse(currentUser.PaymentId));

                PaymentServiceReference.PaymentType paymentType = new PaymentServiceReference.PaymentType();

                if (paypalRadioBtn.Checked) { paymentType = PaymentServiceReference.PaymentType.PayPal; }
                else if (creditCardRadioBtn.Checked) { paymentType = PaymentServiceReference.PaymentType.CreditCard; }
                else if (banktransferRadioBtn.Checked) { paymentType = PaymentServiceReference.PaymentType.BankTransfer; }

                currentpayment.PaymentTypeCode = paymentTypeCodeTxtBox.Text;
                currentpayment.Type = paymentType;  
                currentpayment.UserId = currentUser.Id;

                paymentClient.UpdatePayment(currentpayment);

                GetUserObject();
                SetUserData();


             }
        }

        private void buyCoinsButton_Click(object sender, EventArgs e)
        {
            currentUser.Coins += int.Parse(amountTxtBox.Text);
           
            if (userClient.UpdateUser(currentUser))
            {

                GetUserObject();
                SetUserData();
            }
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (userClient.UpdateUser(currentUser))
            {

                GetUserObject();
            }
        }

        private void yourcurrentpaymentLbl_Click(object sender, EventArgs e)
        {

        }

        private void deleteCurrentPaymentBtn_Click(object sender, EventArgs e)
        {
            if (!currentUser.PaymentId.Equals(""))
            {
                paymentClient.DeletePayment(int.Parse(currentUser.PaymentId));
                GetUserObject();
                SetUserData();
            }
        }
    }
}
