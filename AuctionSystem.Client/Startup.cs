namespace AuctionSystem.Client
{
    
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public static class Startup
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Login l = new Login();
            l.Show();
            //RegistrationForm r = new RegistrationForm();
            //r.ShowDialog();
            ///
            ///
            Application.Run();

        }

    }
}


