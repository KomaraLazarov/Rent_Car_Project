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
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
