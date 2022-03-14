using System;
using Business;
using System.Windows.Forms;

namespace Rent_Buy_Car_Project
{
    public partial class LogInForm : Form
    {
        private RentACarBusiness rentACarBusiness = new RentACarBusiness();

        public LogInForm()
        {
            InitializeComponent();
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            bool IsLogged = this.rentACarBusiness.LogIn(username, password);

            if (IsLogged == false)
            {
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";

                MessageBox.Show("Invalid username or password");
            }
            else
            {
                StartUpForm.startUpFormInstance.buttonRentCar.Visible = true;
                StartUpForm.startUpFormInstance.buttonVehicles.Visible = true;
                StartUpForm.startUpFormInstance.buttonAbout.Visible = true;
                StartUpForm.startUpFormInstance.labelname.Visible = true;
                StartUpForm.startUpFormInstance.labelUsername.Visible = true;

                StartUpForm.startUpFormInstance.username = username;
                StartUpForm.startUpFormInstance.password = password;

                StartUpForm.startUpFormInstance.labelUsername.Text = StartUpForm.startUpFormInstance.username;

                this.LoadForm(new RentACarForm());
            }
        }
        private void LoadForm(object form)
        {
            if (StartUpForm.startUpFormInstance.paneldislpay.Controls.Count > 0)
                StartUpForm.startUpFormInstance.paneldislpay.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            StartUpForm.startUpFormInstance.paneldislpay.Controls.Add(f);
            StartUpForm.startUpFormInstance.paneldislpay.Tag = f;
            f.Show();
        }
        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
