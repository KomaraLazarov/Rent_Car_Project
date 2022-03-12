using System;
using System.Windows.Forms;

namespace Rent_Buy_Car_Project
{
    public partial class StartUpForm : Form
    {
        public string username;
        public string password;

        public static StartUpForm startUpFormInstance;
        public Button buttonRentCar;
        public Button buttonVehicles;
        public Button buttonAbout;
        public Panel paneldislpay;

        public StartUpForm()
        {
            InitializeComponent();

            this.LoadForm(new HomePageForm());
            this.btnOpenRentACarPage.Visible = false;
            this.btnOpenVehiclesPage.Visible = false;
            this.btnOpenAboutPage.Visible = false;

            startUpFormInstance = this;

            buttonRentCar = btnOpenRentACarPage;
            buttonVehicles = btnOpenVehiclesPage;
            buttonAbout = btnOpenAboutPage;
            paneldislpay = panelDisplay;
        }

        private void LoadForm(object form)
        {
            if (this.panelDisplay.Controls.Count > 0)
                this.panelDisplay.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(f);
            this.panelDisplay.Tag = f;
            f.Show();
        }

        private void btnOpenLoginPage_Click(object sender, EventArgs e)
        {
            this.LoadForm(new LogInPageForm());
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenVehiclePage_Click(object sender, EventArgs e)
        {
            this.LoadForm(new VehiclesForm());
        }

        private void btnOpenRentACarPage_Click(object sender, EventArgs e)
        {
            this.LoadForm(new RentACarForm());
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.abv.bg/");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/?lang=bg");
        }

        private void btnWhatsUp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatsapp.com/");
        }

        private void btnOpenAboutPage_Click(object sender, EventArgs e)
        {
            this.LoadForm(new AboutPageForm());
        }

        private void btnOpenHomePage_Click(object sender, EventArgs e)
        {
            this.LoadForm(new HomePageForm());
        }
    }
}
