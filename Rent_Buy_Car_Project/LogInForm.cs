using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Check if username and passwords are valid

            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            bool message = this.rentACarBusiness.LogIn(username, password);

            if (message == false)
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
