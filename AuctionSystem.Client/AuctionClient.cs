namespace AuctionSystem.Client
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Media;
    using System.ServiceModel;
    using System.Windows.Forms;

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
        private ProductService.ProductDto productToUpdate;
        private int currentProductId;
        private int days;
        private int seconds;
        private int minutes;
        private int hours;
        private string dateDiff;
        private string parsedSeconds;
        private string parsedMinutes;
        private string parsedHours;
        private string parsedDays;

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

        }
        #region userRelated
        public void InitializeCatalogueGridView()
        {

            catalogueGridView.DataSource = allProducts;
            catalogueGridView.Columns["RowVersion"].Visible = false;
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
        public void GetUserObject()
        {
            currentUser = userClient.GetUserByUsername(username);
            currentUser.Password = password;
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
                MessageBox.Show(ex.Message);
            }
        }

        private void updateUserBtnClick(object sender, EventArgs e)
        {

            try
            {
                currentUser.Username = usernameTxtBox.Text;
                currentUser.Name = nameTxtBox.Text;
                currentUser.DateOfBirth = DateTime.Parse(birthdateTxtBox.Text);
                currentUser.Phone = phoneNumberTxtBox.Text;
                currentUser.Email = emailTxtBox.Text;
                currentUser.Address = addressTxtbox.Text;
                currentUser.ZipId = int.Parse(zipTxtBox.Text);
                currentUser.Password = passwordTxtBox.Text;


                if (userClient.UpdateUser(currentUser))
                {

                    GetUserObject();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void setUsernameAndPw(string usernamelog, string passwordlog)
        {
            username = usernamelog;
            password = passwordlog;
            GetUserObject();
            loggedasUsernameLbl.Text = username;
            // CheckUserAdmin();

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
        #endregion
        public void HideAllpanels()
        {
            cataloguePanel.Hide();
            myAccountPanel.Hide();
            productPanel.Hide();


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
            InitializeCatalogueGridView();
            HideAllpanels();
            cataloguePanel.BringToFront();
            cataloguePanel.Show();



        }
        private void myaccountbtn_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = myaccountbtn.Height;
            selectionPanel.Top = myaccountbtn.Top;
            SetUserData();
            HideAllpanels();
            myAccountPanel.Show();
            myAccountPanel.BringToFront();

        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (currentUser.IsAdmin == true)
            {
                selectionPanel.Height = settingsBtn.Height;
                selectionPanel.Top = settingsBtn.Top;
                HideAllpanels();
                productPanel.Show();
                productPanel.BringToFront();

            }
            else
            {
                MessageBox.Show("You are not allowed to enter this area!");
            }
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
            HideAllpanels();
            BiddingPanel.Show();
            BiddingPanel.BringToFront();
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
            var bidDtoArray = this.bidService.GetAllBidsByUserId(currentUser.Id);

            dataGridView1.DataSource = bidDtoArray;
        }

        private void MakeBidBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var productName = ProductTextBox.Text;
                var product = this.productService.GetProductByName(productName);
                var productId = product.Id;

                var coins = int.Parse(CoinsTextBox.Text);

                this.bidService.MakeBid(currentUser.Id, productId, coins);

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetProductBids_Click(object sender, EventArgs e)
        {
            try
            {
                var productName = SearchProductTextBox.Text;
                var bidDtoArray = this.bidService.GetAllBidsByProductName(productName);

                dataGridView1.DataSource = bidDtoArray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (sort == 1)
            {

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

        private void ClearProductData()
        {
            itemNameTxtBox.Clear();
            itemDescriptonTxtBox.Clear();
            itemStartDateTxtBox.Clear();
            itemEndDateTxtBox.Clear();
            itemPriceTxtBox.Clear();
        }
        private void saveNewProductBtn_Click(object sender, EventArgs e)
        {
            productService.CreateProduct(CreateNewProductObject());
            MessageBox.Show("Created");
            ClearProductData();


        }
        private ProductService.Product CreateNewProductObject()
        {
            try
            {
                return new ProductService.Product
                {
                    Name = itemNameTxtBox.Text,
                    Description = itemDescriptonTxtBox.Text,
                    StartDate = DateTime.Parse(itemStartDateTxtBox.Text),
                    EndDate = DateTime.Parse(itemEndDateTxtBox.Text),
                    Price = decimal.Parse(itemPriceTxtBox.Text),
                    IsAvailable = true
                };


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void searchForProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                productToUpdate = productService.GetProductById((int)numericUpDown1.Value);
                SetProductData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void SetProductData()
        {
            itemNameTxtBox.Text = productToUpdate.Name;
            itemDescriptonTxtBox.Text = productToUpdate.Description;
            itemStartDateTxtBox.Text = productToUpdate.StartDate.ToString();
            itemEndDateTxtBox.Text = productToUpdate.EndDate.ToString();
            itemPriceTxtBox.Text = productToUpdate.Price.ToString();
            if (productToUpdate.IsAvailable)
            {
                isAvaliableChckBox.Checked = true;
            }


        }

        private void updateExistingProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.productService = new ProductService.ProductServiceClient();
                this.productToUpdate.Name = itemNameTxtBox.Text;
                this.productToUpdate.Description = itemDescriptonTxtBox.Text;
                this.productToUpdate.StartDate = DateTime.Parse(itemStartDateTxtBox.Text);
                this.productToUpdate.EndDate = DateTime.Parse(itemEndDateTxtBox.Text);
                this.productToUpdate.Price = decimal.Parse(itemPriceTxtBox.Text);

                if (!this.productService.UpdateProduct(productToUpdate))
                {
                    MessageBox.Show("Someone has already modified this product, please refresh the page.");
                    return;
                }

                this.productToUpdate.IsAvailable = isAvaliableChckBox.Checked;
                MessageBox.Show("Updated");
                ClearProductData();
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var desiredProduct = productService.GetProductByName(ProductSearchTextBox.Text);
                this.currentProductId = desiredProduct.Id;
                var endDate = desiredProduct.EndDate;

                if (endDate < DateTime.UtcNow)
                {
                    MessageBox.Show("This product has already expired.");
                    ProductName.Text = desiredProduct.Name;
                    TimerTextBox.Text = "00:00:00:00";

                    return;
                }

                this.dateDiff = (endDate.Subtract(DateTime.UtcNow)).ToString(@"dd\:hh\:mm\:ss").Substring(0, 11); // utcnow datetime !!!!!!!

               // ProductName.Text = desiredProduct.Name;

                this.days = int.Parse(dateDiff.Substring(0, 2));
                this.hours = int.Parse(dateDiff.Substring(3, 2));
                this.minutes = int.Parse(dateDiff.Substring(6, 2));
                this.seconds = int.Parse(dateDiff.Substring(9));

                //MessageBox.Show("Bravo");
                using (SoundPlayer player = new SoundPlayer())
                {
                    player.Play();
                }

                timer1.Enabled = true;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                timer1.Stop();

                TimerTextBox.Text = "00:00:00:00";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.seconds--;

            if (this.days == 0
                && this.hours == 0
                && this.minutes == 0
                && this.seconds == 0)
            {
                MessageBox.Show("Product has expired!");

                TimerTextBox.Text = $"0{this.days}:0{this.hours}:0{this.minutes}:0{this.seconds}";

                timer1.Stop();

                MessageBox.Show("We have a winner!");

                return;
            }

            if (this.seconds < 1)
            {
                this.minutes--;
                this.seconds += 59;
            }

            if (this.days == 0
                && this.hours != 0
                && this.minutes != 0)
            {
                if (this.minutes < 1)
                {
                    this.hours--;
                    this.minutes += 59;
                }

                if (this.hours < 1)
                {
                    this.days--;
                    this.hours += 23;
                }
            }

            if (this.days == 0
                && this.hours == 0
                && this.minutes != 0)
            {
                if (this.minutes < 1)
                {
                    this.hours--;
                    this.minutes += 59;
                }
            }

            if (this.seconds < 10)
            {
                this.parsedSeconds = $"0{this.seconds}";
            }
            else
            {
                this.parsedSeconds = this.seconds.ToString();
            }

            if (this.minutes < 10)
            {
                this.parsedMinutes = $"0{this.minutes}";
            }
            else
            {
                this.parsedMinutes = this.minutes.ToString();
            }

            if (this.hours < 10)
            {
                this.parsedHours = $"0{this.hours}";
            }
            else
            {
                this.parsedHours = this.hours.ToString();
            }

            if (this.days < 10)
            {
                this.parsedDays = $"0{this.days}";
            }
            else
            {
                this.parsedDays = this.days.ToString();
            }

            TimerTextBox.Text = $"{this.parsedDays}:{this.parsedHours}:{this.parsedMinutes}:{this.parsedSeconds}";
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
