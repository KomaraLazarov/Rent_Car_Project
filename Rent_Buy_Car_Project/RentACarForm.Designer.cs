
namespace Rent_Buy_Car_Project
{
    partial class RentACarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentACarForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxChooseTypeCar = new System.Windows.Forms.ComboBox();
            this.comboBoxPickLocation = new System.Windows.Forms.ComboBox();
            this.labelChooseCar = new System.Windows.Forms.Label();
            this.labelPickDate = new System.Windows.Forms.Label();
            this.labelPickLocation = new System.Windows.Forms.Label();
            this.btnRentACar = new System.Windows.Forms.Button();
            this.labelThame = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.buttonMakeReservation);
            this.mainPanel.Controls.Add(this.dateTimePickerDate);
            this.mainPanel.Controls.Add(this.comboBoxChooseTypeCar);
            this.mainPanel.Controls.Add(this.comboBoxPickLocation);
            this.mainPanel.Controls.Add(this.labelChooseCar);
            this.mainPanel.Controls.Add(this.labelPickDate);
            this.mainPanel.Controls.Add(this.labelPickLocation);
            this.mainPanel.Location = new System.Drawing.Point(166, 97);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(368, 441);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Visible = false;
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.buttonMakeReservation.FlatAppearance.BorderSize = 0;
            this.buttonMakeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMakeReservation.Location = new System.Drawing.Point(35, 354);
            this.buttonMakeReservation.Name = "buttonMakeReservation";
            this.buttonMakeReservation.Size = new System.Drawing.Size(290, 55);
            this.buttonMakeReservation.TabIndex = 13;
            this.buttonMakeReservation.Text = "Make a Reservation";
            this.buttonMakeReservation.UseVisualStyleBackColor = false;
            this.buttonMakeReservation.Click += new System.EventHandler(this.buttonMakeReservation_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(45, 196);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(290, 20);
            this.dateTimePickerDate.TabIndex = 12;
            // 
            // comboBoxChooseTypeCar
            // 
            this.comboBoxChooseTypeCar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxChooseTypeCar.FormattingEnabled = true;
            this.comboBoxChooseTypeCar.Location = new System.Drawing.Point(43, 295);
            this.comboBoxChooseTypeCar.Name = "comboBoxChooseTypeCar";
            this.comboBoxChooseTypeCar.Size = new System.Drawing.Size(292, 21);
            this.comboBoxChooseTypeCar.TabIndex = 10;
            this.comboBoxChooseTypeCar.Text = "-Select-";
            // 
            // comboBoxPickLocation
            // 
            this.comboBoxPickLocation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxPickLocation.FormattingEnabled = true;
            this.comboBoxPickLocation.Location = new System.Drawing.Point(45, 84);
            this.comboBoxPickLocation.Name = "comboBoxPickLocation";
            this.comboBoxPickLocation.Size = new System.Drawing.Size(290, 21);
            this.comboBoxPickLocation.TabIndex = 11;
            this.comboBoxPickLocation.Text = "-Select a City-";
            // 
            // labelChooseCar
            // 
            this.labelChooseCar.AutoSize = true;
            this.labelChooseCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelChooseCar.Location = new System.Drawing.Point(31, 254);
            this.labelChooseCar.Name = "labelChooseCar";
            this.labelChooseCar.Size = new System.Drawing.Size(140, 19);
            this.labelChooseCar.TabIndex = 7;
            this.labelChooseCar.Text = "Choose Car Type";
            // 
            // labelPickDate
            // 
            this.labelPickDate.AutoSize = true;
            this.labelPickDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPickDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelPickDate.Location = new System.Drawing.Point(31, 145);
            this.labelPickDate.Name = "labelPickDate";
            this.labelPickDate.Size = new System.Drawing.Size(109, 19);
            this.labelPickDate.TabIndex = 8;
            this.labelPickDate.Text = "Pick-Up Date";
            // 
            // labelPickLocation
            // 
            this.labelPickLocation.AutoSize = true;
            this.labelPickLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPickLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelPickLocation.Location = new System.Drawing.Point(31, 33);
            this.labelPickLocation.Name = "labelPickLocation";
            this.labelPickLocation.Size = new System.Drawing.Size(139, 19);
            this.labelPickLocation.TabIndex = 9;
            this.labelPickLocation.Text = "Pick-Up Location";
            // 
            // btnRentACar
            // 
            this.btnRentACar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.btnRentACar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRentACar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnRentACar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRentACar.FlatAppearance.BorderSize = 0;
            this.btnRentACar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentACar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRentACar.ForeColor = System.Drawing.Color.Black;
            this.btnRentACar.Location = new System.Drawing.Point(166, 57);
            this.btnRentACar.Name = "btnRentACar";
            this.btnRentACar.Size = new System.Drawing.Size(368, 40);
            this.btnRentACar.TabIndex = 5;
            this.btnRentACar.Text = "Rent a Car";
            this.btnRentACar.UseVisualStyleBackColor = false;
            this.btnRentACar.Visible = false;
            // 
            // labelThame
            // 
            this.labelThame.AutoSize = true;
            this.labelThame.BackColor = System.Drawing.Color.Transparent;
            this.labelThame.Font = new System.Drawing.Font("Consolas", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThame.ForeColor = System.Drawing.Color.Black;
            this.labelThame.Location = new System.Drawing.Point(551, 7);
            this.labelThame.Name = "labelThame";
            this.labelThame.Size = new System.Drawing.Size(511, 72);
            this.labelThame.TabIndex = 9;
            this.labelThame.Text = "RENT A CAR IN SMOLYAN,BULGARIA \r\nat competitive prices\r\n";
            this.labelThame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RentACarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 550);
            this.Controls.Add(this.labelThame);
            this.Controls.Add(this.btnRentACar);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentACarForm";
            this.Text = "RentACarForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnRentACar;
        private System.Windows.Forms.Label labelThame;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxChooseTypeCar;
        private System.Windows.Forms.ComboBox comboBoxPickLocation;
        private System.Windows.Forms.Label labelChooseCar;
        private System.Windows.Forms.Label labelPickDate;
        private System.Windows.Forms.Label labelPickLocation;
        private System.Windows.Forms.Button buttonMakeReservation;
    }
}