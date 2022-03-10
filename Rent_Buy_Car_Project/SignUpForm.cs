using Business;
using Data.Models;
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
    public partial class SignUpForm : Form
    {
        private RentACarBusiness rentACarBusiness = new RentACarBusiness();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Check if there is already user with this email address
            // Else add user to database
            // Empty all the textboxes

            string username = this.txtUsername.Text;
            string firstName = this.txtFirstName.Text;
            string middleName = this.txtMiddleName.Text;
            string lastName = this.txtLastName.Text;
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;
            string phone = this.txtPhone.Text;
            DateTime birthDate = DateTime.Parse(this.dateTimePickerBirthDate.Text);

            User user = new User(username, password, firstName, middleName, lastName, email, phone, birthDate);

            bool message = this.rentACarBusiness.SignUp(user);

            if (message == false)
            {
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";

                MessageBox.Show("User already exist");
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
        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
