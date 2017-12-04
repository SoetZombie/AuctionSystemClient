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
        private IList<ProductService.ProductDto> allProducts;
        private int sort, sort2, sort3, sort4;



        public static string username;
        public static string password;


        public AuctionClient()
        {
            this.productService = new ProductService.ProductServiceClient();
            this.bidService = new BidService.BidServiceClient();
            this.userClient = new UserService.UserServiceClient();
            this.zipService = new ZipServiceReference.ZipServiceClient();
            paymentClient = new PaymentServiceReference.PaymentServiceClient();
            allProducts = productService.GetAllProducts().ToList();
            InitializeComponent();
            HideAllpanels();
            CheckUserAdmin();

        }
        public void InitializeCatalogueGridView()
        {
            catalogueGridView.DataSource = allProducts;
            catalogueGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            catalogueGridView.Columns["Bids"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalogueGridView.Columns["Bids"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            catalogueGridView.Columns["Id"].DisplayIndex = 0;
            catalogueGridView.Columns["Name"].DisplayIndex = 1;
            catalogueGridView.Columns["Description"].DisplayIndex = 2;
            catalogueGridView.Columns["isAvailable"].DisplayIndex = 3;
            catalogueGridView.Columns["Price"].DisplayIndex = 4;
            catalogueGridView.Columns["StartDate"].DisplayIndex = 5;
            catalogueGridView.Columns["EndDate"].DisplayIndex = 6;
            catalogueGridView.Columns["Bids"].DisplayIndex = 7;

        }
        public void CheckUserAdmin()
        {
            settingsBtn.Hide();

            if (currentUser.IsAdmin == true)
            {
                settingsBtn.Show();
            }
        }
        public void HideAllpanels()
        {
            cataloguePanel.Hide();
            myAccountPanel.Hide();
            
        }
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x84:
        //            base.WndProc(ref m);
        //            if ((int)m.Result == 0x1)
        //                m.Result = (IntPtr)0x2;
        //            return;
        //    }

        //    base.WndProc(ref m);
        //}
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
      
        private void exitBtnClick(object sender, EventArgs e)
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
        private void catalogueBtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = catalogueBtn.Height;
            selectionPanel.Top = catalogueBtn.Top;
            HideAllpanels();
            cataloguePanel.Show();
            InitializeCatalogueGridView();
            cataloguePanel.BringToFront();



        }
        private void myaccountbtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = myaccountbtn.Height;
            selectionPanel.Top = myaccountbtn.Top;
            SetUserData();
            HideAllpanels();
            myAccountPanel.Show();
            
        }
        private void SetUserData()
        {
           
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
          
            try
            {
                int coins;
                if (!Int32.TryParse(amountTxtBox.Text, out coins))
                {
                    throw new ArgumentException("put only numbers please");
                }
                if (coins <= 0)
                {
                    throw new ArgumentException("coins cannot be negative or zero");
                }

                currentUser.Coins += coins;

                if (userClient.UpdateUser(currentUser))
                {

                    GetUserObject();
                    SetUserData();
                }

            }
            catch (Exception ex)
            {

                CreateExceptionDialog(ex.Message);

            }

            //  }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            currentUser.Username = usernameTxtBox.Text;
            currentUser.Name = nameTxtBox.Text;
            currentUser.DateOfBirth = DateTime.Parse(birthdateTxtBox.Text);
            currentUser.Phone = phoneNumberTxtBox.Text;
            currentUser.Email = emailTxtBox.Text;
            currentUser.Address = addressTxtbox.Text;
            currentUser.ZipId = int.Parse(zipTxtBox.Text);
            currentUser.Password = passwordTxtBox.Text;
            try
            {


                if (userClient.UpdateUser(currentUser))
                {

                    GetUserObject();
                }
            }
            catch (Exception ex)
            {
                CreateExceptionDialog(ex.Message);

            }
        }

        private void CreateExceptionDialog(string errorMsg)
        {
            DialogWindow d = new DialogWindow();
            d.SetErrorMsg(errorMsg);
            d.StartPosition = FormStartPosition.CenterParent;
            d.ShowDialog(this);
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

        private void cataloguePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sortbyclick(object sender, EventArgs e)
        {
            if (sort == 0)
            {
                allProducts.OrderBy(o => o.StartDate).ToList();
                InitializeCatalogueGridView();
                sort = 1;
            }
            if (sort == 1)
            {
                allProducts.OrderBy(o => o.EndDate).ToList();
                InitializeCatalogueGridView();
                sort = 0;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (sort ==1){

                allProducts = allProducts.OrderBy(x => x.StartDate).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort = 0;
                sortByStartDate.Text = "Sort by start date ↑ ";


            }
            else
            {

                allProducts = allProducts.OrderByDescending(x => x.StartDate).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort = 1;
                sortByStartDate.Text = "Sort by start date ↓ ";
            }
          
        }

        private void sortByEndDateBtn_Click(object sender, EventArgs e)
        {
            if (sort2 == 1)
            {

                allProducts = allProducts.OrderBy(x => x.EndDate).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort2 = 0;
                sortByEndDateBtn.Text = "Sort by end date ↑ ";


            }
            else
            {

                allProducts = allProducts.OrderByDescending(x => x.EndDate).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort2 = 1;
                sortByEndDateBtn.Text = "Sort by end date ↓ ";
            }
        }

        private void sortByNameBtn_Click(object sender, EventArgs e)
        {
            if (sort3 == 1)
            {

                allProducts = allProducts.OrderBy(x => x.Name).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort3 = 0;
                sortByNameBtn.Text = "Sort by name ↑ ";


            }
            else
            {

                allProducts = allProducts.OrderByDescending(x => x.Name).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort3 = 1;
                sortByNameBtn.Text = "Sort by name ↓ ";
            }
        }

        private void sortByPriceBTn_Click(object sender, EventArgs e)
        {
            if (sort4 == 1)
            {

                allProducts = allProducts.OrderBy(x => x.Price).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort4 = 0;
                sortByPriceBTn.Text = "Sort by price ↑ ";


            }
            else
            {

                allProducts = allProducts.OrderByDescending(x => x.Price).ToList();
                catalogueGridView.DataSource = allProducts;
                catalogueGridView.Refresh();
                sort4 = 1;
                sortByPriceBTn.Text = "Sort by price ↓ ";
            }
        }
    }
}
