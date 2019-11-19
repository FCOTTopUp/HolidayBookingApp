namespace HolidayBooking
{
    partial class MainForm
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
            this.plGetLocation = new System.Windows.Forms.Panel();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.lbGetHolidayLocation = new System.Windows.Forms.Label();
            this.plBookingDates = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BookingProgressBar = new System.Windows.Forms.ProgressBar();
            this.Navbtn1NewBooking = new System.Windows.Forms.Button();
            this.Navbtn2Dates = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Navbtn3Flights = new System.Windows.Forms.Button();
            this.Navbtn4Hotel = new System.Windows.Forms.Button();
            this.Navbtn5Car = new System.Windows.Forms.Button();
            this.Navbtn6Inusrance = new System.Windows.Forms.Button();
            this.Navbtn7CheckDetails = new System.Windows.Forms.Button();
            this.Navbtn8Summary = new System.Windows.Forms.Button();
            this.Navbtn9Payments = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.plGetLocation.SuspendLayout();
            this.plBookingDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGetLocation
            // 
            this.plGetLocation.Controls.Add(this.cbLocations);
            this.plGetLocation.Controls.Add(this.lbGetHolidayLocation);
            this.plGetLocation.Location = new System.Drawing.Point(12, 39);
            this.plGetLocation.Name = "plGetLocation";
            this.plGetLocation.Size = new System.Drawing.Size(562, 348);
            this.plGetLocation.TabIndex = 0;
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(106, 143);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(326, 21);
            this.cbLocations.TabIndex = 1;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // lbGetHolidayLocation
            // 
            this.lbGetHolidayLocation.AutoSize = true;
            this.lbGetHolidayLocation.Location = new System.Drawing.Point(188, 114);
            this.lbGetHolidayLocation.Name = "lbGetHolidayLocation";
            this.lbGetHolidayLocation.Size = new System.Drawing.Size(142, 13);
            this.lbGetHolidayLocation.TabIndex = 0;
            this.lbGetHolidayLocation.Text = "Where would you like to go?";
            // 
            // plBookingDates
            // 
            this.plBookingDates.Controls.Add(this.dateTimePicker2);
            this.plBookingDates.Controls.Add(this.label4);
            this.plBookingDates.Controls.Add(this.monthCalendar1);
            this.plBookingDates.Controls.Add(this.label2);
            this.plBookingDates.Controls.Add(this.label3);
            this.plBookingDates.Controls.Add(this.dateTimePicker1);
            this.plBookingDates.Location = new System.Drawing.Point(17, 43);
            this.plBookingDates.Name = "plBookingDates";
            this.plBookingDates.Size = new System.Drawing.Size(617, 347);
            this.plBookingDates.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Location = new System.Drawing.Point(213, 247);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(202, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(285, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calendar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // BookingProgressBar
            // 
            this.BookingProgressBar.Location = new System.Drawing.Point(1022, 2);
            this.BookingProgressBar.Name = "BookingProgressBar";
            this.BookingProgressBar.Size = new System.Drawing.Size(130, 30);
            this.BookingProgressBar.TabIndex = 2;
            this.BookingProgressBar.Value = 50;
            // 
            // Navbtn1NewBooking
            // 
            this.Navbtn1NewBooking.Location = new System.Drawing.Point(1, 2);
            this.Navbtn1NewBooking.Name = "Navbtn1NewBooking";
            this.Navbtn1NewBooking.Size = new System.Drawing.Size(94, 30);
            this.Navbtn1NewBooking.TabIndex = 3;
            this.Navbtn1NewBooking.Text = "New Booking";
            this.Navbtn1NewBooking.UseVisualStyleBackColor = true;
            // 
            // Navbtn2Dates
            // 
            this.Navbtn2Dates.Location = new System.Drawing.Point(94, 2);
            this.Navbtn2Dates.Name = "Navbtn2Dates";
            this.Navbtn2Dates.Size = new System.Drawing.Size(80, 30);
            this.Navbtn2Dates.TabIndex = 4;
            this.Navbtn2Dates.Text = "Dates";
            this.Navbtn2Dates.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1158, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Navbtn3Flights
            // 
            this.Navbtn3Flights.Location = new System.Drawing.Point(173, 2);
            this.Navbtn3Flights.Name = "Navbtn3Flights";
            this.Navbtn3Flights.Size = new System.Drawing.Size(101, 30);
            this.Navbtn3Flights.TabIndex = 6;
            this.Navbtn3Flights.Text = "Optional: Flights";
            this.Navbtn3Flights.UseVisualStyleBackColor = true;
            // 
            // Navbtn4Hotel
            // 
            this.Navbtn4Hotel.Location = new System.Drawing.Point(274, 3);
            this.Navbtn4Hotel.Name = "Navbtn4Hotel";
            this.Navbtn4Hotel.Size = new System.Drawing.Size(124, 29);
            this.Navbtn4Hotel.TabIndex = 7;
            this.Navbtn4Hotel.Text = "Optional: Hotel";
            this.Navbtn4Hotel.UseVisualStyleBackColor = true;
            // 
            // Navbtn5Car
            // 
            this.Navbtn5Car.Location = new System.Drawing.Point(398, 3);
            this.Navbtn5Car.Name = "Navbtn5Car";
            this.Navbtn5Car.Size = new System.Drawing.Size(124, 29);
            this.Navbtn5Car.TabIndex = 8;
            this.Navbtn5Car.Text = "Optional: Car";
            this.Navbtn5Car.UseVisualStyleBackColor = true;
            // 
            // Navbtn6Inusrance
            // 
            this.Navbtn6Inusrance.Location = new System.Drawing.Point(522, 3);
            this.Navbtn6Inusrance.Name = "Navbtn6Inusrance";
            this.Navbtn6Inusrance.Size = new System.Drawing.Size(124, 29);
            this.Navbtn6Inusrance.TabIndex = 9;
            this.Navbtn6Inusrance.Text = "Optional: Insurance";
            this.Navbtn6Inusrance.UseVisualStyleBackColor = true;
            // 
            // Navbtn7CheckDetails
            // 
            this.Navbtn7CheckDetails.Location = new System.Drawing.Point(646, 3);
            this.Navbtn7CheckDetails.Name = "Navbtn7CheckDetails";
            this.Navbtn7CheckDetails.Size = new System.Drawing.Size(124, 29);
            this.Navbtn7CheckDetails.TabIndex = 10;
            this.Navbtn7CheckDetails.Text = "Check Details";
            this.Navbtn7CheckDetails.UseVisualStyleBackColor = true;
            // 
            // Navbtn8Summary
            // 
            this.Navbtn8Summary.Location = new System.Drawing.Point(771, 3);
            this.Navbtn8Summary.Name = "Navbtn8Summary";
            this.Navbtn8Summary.Size = new System.Drawing.Size(124, 29);
            this.Navbtn8Summary.TabIndex = 11;
            this.Navbtn8Summary.Text = "Summary";
            this.Navbtn8Summary.UseVisualStyleBackColor = true;
            // 
            // Navbtn9Payments
            // 
            this.Navbtn9Payments.Location = new System.Drawing.Point(896, 3);
            this.Navbtn9Payments.Name = "Navbtn9Payments";
            this.Navbtn9Payments.Size = new System.Drawing.Size(124, 29);
            this.Navbtn9Payments.TabIndex = 12;
            this.Navbtn9Payments.Text = "Payments";
            this.Navbtn9Payments.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(12, 614);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(73, 30);
            this.btnPreviousPage.TabIndex = 13;
            this.btnPreviousPage.Text = "Back";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(1151, 614);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(73, 30);
            this.btnNextPage.TabIndex = 14;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 656);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.Navbtn9Payments);
            this.Controls.Add(this.Navbtn8Summary);
            this.Controls.Add(this.Navbtn7CheckDetails);
            this.Controls.Add(this.Navbtn6Inusrance);
            this.Controls.Add(this.Navbtn5Car);
            this.Controls.Add(this.Navbtn4Hotel);
            this.Controls.Add(this.Navbtn3Flights);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Navbtn2Dates);
            this.Controls.Add(this.Navbtn1NewBooking);
            this.Controls.Add(this.BookingProgressBar);
            this.Controls.Add(this.plGetLocation);
            this.Controls.Add(this.plBookingDates);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plGetLocation.ResumeLayout(false);
            this.plGetLocation.PerformLayout();
            this.plBookingDates.ResumeLayout(false);
            this.plBookingDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plGetLocation;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Label lbGetHolidayLocation;
        private System.Windows.Forms.Panel plBookingDates;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ProgressBar BookingProgressBar;
        private System.Windows.Forms.Button Navbtn1NewBooking;
        private System.Windows.Forms.Button Navbtn2Dates;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Navbtn3Flights;
        private System.Windows.Forms.Button Navbtn4Hotel;
        private System.Windows.Forms.Button Navbtn5Car;
        private System.Windows.Forms.Button Navbtn6Inusrance;
        private System.Windows.Forms.Button Navbtn7CheckDetails;
        private System.Windows.Forms.Button Navbtn8Summary;
        private System.Windows.Forms.Button Navbtn9Payments;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
    }
}