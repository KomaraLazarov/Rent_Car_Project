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
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
        }
        private void guna2TrackBarYear_Scroll(object sender, ScrollEventArgs e)
        {
            this.lblYear.Text = this.guna2TrackBarYear.Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBoxImage.Image = this.pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBoxImage.Image = this.pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.pictureBoxImage.Image = this.pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBoxImage.Image = this.pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.pictureBoxImage.Image = this.pictureBox5.Image;
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
