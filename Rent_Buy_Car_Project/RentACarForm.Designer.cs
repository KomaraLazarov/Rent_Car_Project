﻿
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
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnMakeAReservation = new System.Windows.Forms.Button();
            this.dateTimePickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxChooseTypeCar = new System.Windows.Forms.ComboBox();
            this.labelChooseCar = new System.Windows.Forms.Label();
            this.labelPickDate = new System.Windows.Forms.Label();
            this.labelPickLocation = new System.Windows.Forms.Label();
            this.btnRentACar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.dateTimePickerReturnDate);
            this.mainPanel.Controls.Add(this.btnMakeAReservation);
            this.mainPanel.Controls.Add(this.dateTimePickerHireDate);
            this.mainPanel.Controls.Add(this.comboBoxChooseTypeCar);
            this.mainPanel.Controls.Add(this.labelChooseCar);
            this.mainPanel.Controls.Add(this.labelPickDate);
            this.mainPanel.Controls.Add(this.labelPickLocation);
            this.mainPanel.Location = new System.Drawing.Point(208, 121);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(460, 551);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Visible = false;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(43, 175);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(362, 22);
            this.dateTimePickerReturnDate.TabIndex = 14;
            // 
            // btnMakeAReservation
            // 
            this.btnMakeAReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.btnMakeAReservation.FlatAppearance.BorderSize = 0;
            this.btnMakeAReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeAReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeAReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMakeAReservation.Location = new System.Drawing.Point(45, 466);
            this.btnMakeAReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeAReservation.Name = "btnMakeAReservation";
            this.btnMakeAReservation.Size = new System.Drawing.Size(362, 69);
            this.btnMakeAReservation.TabIndex = 13;
            this.btnMakeAReservation.Text = "Make a Reservation";
            this.btnMakeAReservation.UseVisualStyleBackColor = false;
            this.btnMakeAReservation.Click += new System.EventHandler(this.btnMakeAReservation_Click);
            // 
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(43, 82);
            this.dateTimePickerHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(362, 22);
            this.dateTimePickerHireDate.TabIndex = 12;
            // 
            // comboBoxChooseTypeCar
            // 
            this.comboBoxChooseTypeCar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxChooseTypeCar.FormattingEnabled = true;
            this.comboBoxChooseTypeCar.Location = new System.Drawing.Point(43, 287);
            this.comboBoxChooseTypeCar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChooseTypeCar.Name = "comboBoxChooseTypeCar";
            this.comboBoxChooseTypeCar.Size = new System.Drawing.Size(364, 24);
            this.comboBoxChooseTypeCar.TabIndex = 10;
            this.comboBoxChooseTypeCar.Text = "-Select-";
            // 
            // labelChooseCar
            // 
            this.labelChooseCar.AutoSize = true;
            this.labelChooseCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelChooseCar.Location = new System.Drawing.Point(39, 247);
            this.labelChooseCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseCar.Name = "labelChooseCar";
            this.labelChooseCar.Size = new System.Drawing.Size(179, 23);
            this.labelChooseCar.TabIndex = 7;
            this.labelChooseCar.Text = "Choose Car Type";
            // 
            // labelPickDate
            // 
            this.labelPickDate.AutoSize = true;
            this.labelPickDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPickDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelPickDate.Location = new System.Drawing.Point(39, 137);
            this.labelPickDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPickDate.Name = "labelPickDate";
            this.labelPickDate.Size = new System.Drawing.Size(229, 23);
            this.labelPickDate.TabIndex = 8;
            this.labelPickDate.Text = "Pick-Up Date to Return";
            // 
            // labelPickLocation
            // 
            this.labelPickLocation.AutoSize = true;
            this.labelPickLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPickLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.labelPickLocation.Location = new System.Drawing.Point(39, 41);
            this.labelPickLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPickLocation.Name = "labelPickLocation";
            this.labelPickLocation.Size = new System.Drawing.Size(206, 23);
            this.labelPickLocation.TabIndex = 9;
            this.labelPickLocation.Text = "Pick-Up Date to Hire";
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
            this.btnRentACar.Location = new System.Drawing.Point(208, 71);
            this.btnRentACar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentACar.Name = "btnRentACar";
            this.btnRentACar.Size = new System.Drawing.Size(460, 50);
            this.btnRentACar.TabIndex = 5;
            this.btnRentACar.Text = "Rent a Car";
            this.btnRentACar.UseVisualStyleBackColor = false;
            this.btnRentACar.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(43, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 92);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(248, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 16;
            // 
            // RentACarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1479, 688);
            this.Controls.Add(this.btnRentACar);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentACarForm";
            this.Text = "RentACarForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnRentACar;
        private System.Windows.Forms.DateTimePicker dateTimePickerHireDate;
        private System.Windows.Forms.ComboBox comboBoxChooseTypeCar;
        private System.Windows.Forms.Label labelChooseCar;
        private System.Windows.Forms.Label labelPickDate;
        private System.Windows.Forms.Label labelPickLocation;
        private System.Windows.Forms.Button btnMakeAReservation;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}