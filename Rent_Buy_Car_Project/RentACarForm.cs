﻿using System;
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
    public partial class RentACarForm : Form
    {
        public RentACarForm()
        {
            InitializeComponent();
            btnRentACar.Visible = true;
            mainPanel.Visible = true;
        }

        private void btnMakeAReservation_Click(object sender, EventArgs e)
        {
            // If car is already rented-- Show correct message
        }
    }
}
