using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rent_Buy_Car_Project
{
    public partial class RentACarForm : Form
    {
        private RentACarBusiness rentACarBusiness = new RentACarBusiness();

        public RentACarForm()
        {
            InitializeComponent();
            btnRentACar.Visible = true;
            mainPanel.Visible = true;
        }

        private void btnMakeAReservation_Click(object sender, EventArgs e)
        {
            DateTime hireDate = DateTime.Parse(this.dateTimePickerHireDate.Text);
            DateTime returnDate = DateTime.Parse(this.dateTimePickerReturnDate.Text);
            string[] carProperties = comboBoxChooseCar.SelectedItem.ToString().Split().ToArray();
            string username = StartUpForm.startUpFormInstance.username;

            try
            {
                this.rentACarBusiness.MakeReservation(username, carProperties, hireDate, returnDate);
                MessageBox.Show("Rented!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            DateTime hireDate = DateTime.Parse(this.dateTimePickerHireDate.Text);
            DateTime returnDate = DateTime.Parse(this.dateTimePickerReturnDate.Text);

            if (this.comboBoxChooseCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please, choose a car!");
            }
            else
            {
                string[] carProperties = comboBoxChooseCar.SelectedItem.ToString().Split().ToArray();
                this.label1.Text = this.rentACarBusiness.CalculateTotalPrice(hireDate, returnDate, carProperties).ToString();
            }
        }
    }
}
