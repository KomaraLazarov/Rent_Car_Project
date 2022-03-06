
namespace Rent_Buy_Car_Project
{
    partial class LogInPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPageForm));
            this.btnOpenLoginPage_2 = new System.Windows.Forms.Button();
            this.btnOpenSignInPage = new System.Windows.Forms.Button();
            this.LabelTheme = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnOpenLoginPage_2
            // 
            this.btnOpenLoginPage_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.btnOpenLoginPage_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenLoginPage_2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnOpenLoginPage_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpenLoginPage_2.FlatAppearance.BorderSize = 0;
            this.btnOpenLoginPage_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLoginPage_2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenLoginPage_2.ForeColor = System.Drawing.Color.Black;
            this.btnOpenLoginPage_2.Location = new System.Drawing.Point(166, 57);
            this.btnOpenLoginPage_2.Name = "btnOpenLoginPage_2";
            this.btnOpenLoginPage_2.Size = new System.Drawing.Size(184, 40);
            this.btnOpenLoginPage_2.TabIndex = 4;
            this.btnOpenLoginPage_2.Text = "Log In";
            this.btnOpenLoginPage_2.UseVisualStyleBackColor = false;
            this.btnOpenLoginPage_2.Visible = false;
            this.btnOpenLoginPage_2.Click += new System.EventHandler(this.btnOpenLoginPage_2_Click);
            // 
            // btnOpenSignInPage
            // 
            this.btnOpenSignInPage.BackColor = System.Drawing.Color.White;
            this.btnOpenSignInPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenSignInPage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnOpenSignInPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpenSignInPage.FlatAppearance.BorderSize = 0;
            this.btnOpenSignInPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSignInPage.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenSignInPage.ForeColor = System.Drawing.Color.Black;
            this.btnOpenSignInPage.Location = new System.Drawing.Point(350, 57);
            this.btnOpenSignInPage.Name = "btnOpenSignInPage";
            this.btnOpenSignInPage.Size = new System.Drawing.Size(184, 40);
            this.btnOpenSignInPage.TabIndex = 5;
            this.btnOpenSignInPage.Text = "Sign in";
            this.btnOpenSignInPage.UseVisualStyleBackColor = false;
            this.btnOpenSignInPage.Visible = false;
            this.btnOpenSignInPage.Click += new System.EventHandler(this.btnOpenSignInPage_Click_1);
            // 
            // LabelTheme
            // 
            this.LabelTheme.AutoSize = true;
            this.LabelTheme.BackColor = System.Drawing.Color.Transparent;
            this.LabelTheme.Font = new System.Drawing.Font("Consolas", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTheme.ForeColor = System.Drawing.Color.Black;
            this.LabelTheme.Location = new System.Drawing.Point(551, 7);
            this.LabelTheme.Name = "LabelTheme";
            this.LabelTheme.Size = new System.Drawing.Size(511, 72);
            this.LabelTheme.TabIndex = 6;
            this.LabelTheme.Text = "RENT A CAR IN SMOLYAN,BULGARIA \r\nat competitive prices\r\n";
            this.LabelTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(166, 97);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(368, 441);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.Visible = false;
            // 
            // LogInPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 589);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.LabelTheme);
            this.Controls.Add(this.btnOpenSignInPage);
            this.Controls.Add(this.btnOpenLoginPage_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInPageForm";
            this.Text = "LogInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenLoginPage_2;
        private System.Windows.Forms.Button btnOpenSignInPage;
        private System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.Panel mainPanel;
    }
}