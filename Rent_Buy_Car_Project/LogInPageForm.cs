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
    public partial class LogInPageForm : Form
    {
        public LogInPageForm()
        {
            InitializeComponent();
            btnOpenLoginPage_2.Visible = true;
            btnOpenSignInPage.Visible = true;
            mainPanel.Visible = true;
            this.LoadForm(new LogInForm());
        }

        private void btnOpenLoginPage_2_Click(object sender, EventArgs e)
        {
            this.btnOpenLoginPage_2.BackColor = Color.FromArgb(225, 195, 4);
            this.btnOpenSignInPage.BackColor = Color.White;

            this.LoadForm(new LogInForm());
        }
        private void LoadForm(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnOpenSignInPage_Click_1(object sender, EventArgs e)
        {
            this.btnOpenLoginPage_2.BackColor = Color.White;
            this.btnOpenSignInPage.BackColor = Color.FromArgb(225, 195, 4);

            this.LoadForm(new SignUpForm());
        }
    }
}
