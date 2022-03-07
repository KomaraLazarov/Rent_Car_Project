
namespace Rent_Buy_Car_Project
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.LabelTheme = new System.Windows.Forms.Label();
            this.labelPickLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTheme
            // 
            this.LabelTheme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelTheme.AutoSize = true;
            this.LabelTheme.BackColor = System.Drawing.Color.Transparent;
            this.LabelTheme.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(145)))), ((int)(((byte)(4)))));
            this.LabelTheme.Location = new System.Drawing.Point(39, 18);
            this.LabelTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTheme.Name = "LabelTheme";
            this.LabelTheme.Size = new System.Drawing.Size(1138, 138);
            this.LabelTheme.TabIndex = 7;
            this.LabelTheme.Text = "RENT A CAR IN SMOLYAN,BULGARIA \r\nat competitive prices\r\n";
            this.LabelTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPickLocation
            // 
            this.labelPickLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPickLocation.AutoSize = true;
            this.labelPickLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelPickLocation.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPickLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelPickLocation.Location = new System.Drawing.Point(778, 452);
            this.labelPickLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPickLocation.Name = "labelPickLocation";
            this.labelPickLocation.Size = new System.Drawing.Size(399, 108);
            this.labelPickLocation.TabIndex = 10;
            this.labelPickLocation.Text = "Contact us on:\r\n        +359 876 874 321\r\n        +359 878 935 223";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 589);
            this.Controls.Add(this.labelPickLocation);
            this.Controls.Add(this.LabelTheme);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.Label labelPickLocation;
    }
}