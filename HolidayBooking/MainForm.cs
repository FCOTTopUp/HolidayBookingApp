using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayBooking
{
    public partial class MainForm : Form
    {
        //********************************** Initalisations of Lists ****************************************************
        //List used for navigation of panels
        List<Panel> NavPanels = new List<Panel>();
        int NavIndex;
        int MaxNavIndex;

        //List used for locations
        List<string>Alllocations = new List<string> { "One", "Two", "Three" };


        //Creation of customer object to hold all users details either that have just been made or retrieved from the database
        CustomerDetails CurrentCustomer = new CustomerDetails();

        NewBooking CurrentBooking = new NewBooking();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Adds all the panels to a list on start up so nav code can flip through them abnd resets index
            NavIndex = 0;
            NavPanels.Add(plPg1GetLocation);
            NavPanels.Add(plPg2BookingDates);
            NavPanels.Add(plPg3Flight);
            NavPanels.Add(plPg4Hotel);
            NavPanels.Add(plPg5CarHire);
            NavPanels.Add(plPg6Insurance);
            NavPanels.Add(plPg7CheckDetails);
            NavPanels.Add(plPg8Summary);
            NavPanels.Add(plPg9Payment);
            LoadPage();

            //Setup of locations combobox
            var LocationBindingSource = new BindingSource();
            LocationBindingSource.DataSource = Alllocations;
            cbPg1GetLocation.DataSource = LocationBindingSource.DataSource;
        }

        #region GENERAL BUTTONS AND FUNCTIONS
        //********************************** General Buttons and functions ****************************************************
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the Application
            //TO ADD GIVE THE OPTION OF LOG OUT ONLY
            Application.Exit();
        }

        #region PAGE NAVIGATION
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            //Takes user back one page in navigation
            if (NavIndex > 0)
            {
                NavIndex--;
                LoadPage();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            //Takes user to next page in navigation
            if (NavIndex < NavPanels.Count - 1)
            {
                NavIndex++;
                LoadPage();
                if (NavIndex == 1)
                {
                    //Create new object of new booking and pass it variables
                    CurrentBooking.SetupBooking(cbPg1GetLocation.SelectedIndex, Convert.ToInt32(tbPg1NoOfAdults.Text), Convert.ToInt32(tbPg1NoOfChildren.Text));
                }
            }
            else if (NavIndex ==8)
            {
                Comfirmation comfirmation = new Comfirmation();
                comfirmation.Show();
                this.Hide();
            }
        }

        private void LoadPage()
        {
            //Loads the new page by bringing the panel to the front
            NavPanels[NavIndex].BringToFront();
            updateProgressBar(NavIndex);
            PageChecker();

            //Call page checker 
        }


        private void updateProgressBar(int _NavIndex)
        {
            if (NavIndex > MaxNavIndex)
            {
                MaxNavIndex = NavIndex;
            }

            //Updates progress bar form the use of the nav index
            BookingProgressBar.Value = ((_NavIndex +1) * 10);
            EnableNavButtons();
        }

        private void PageChecker()
        {
            if (NavIndex == 0)
            { page1NewBookingSetup(); }
            else if (NavIndex == 1)
            { page2DatesSetup(); }
            else if (NavIndex == 2)
            { page3FlightsSetup(); }
            else if (NavIndex == 3)
            { page4HotelSetup(); }
            else if (NavIndex == 4)
            { page5CarSetup(); }
            else if (NavIndex == 5)
            { page6InsuranceSetup(); }
            else if (NavIndex == 6)
            { page7CheckDetailsSetup(); }
            else if (NavIndex == 7)
            { page8SummarySetup(); }
            else if (NavIndex == 8)
            { page9PaymentsSetup(); }
        }
        #endregion

        #region PAGE SETUP
        private void page1NewBookingSetup()
        {
            btnPreviousPage.Enabled = false;
            btnNextPage.Enabled = true;
        }

        private void page2DatesSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;

            dtPg2HolidayStart.MinDate = DateTime.Today;
            dtPg2HolidayEnd.MinDate = DateTime.Today;
            dtPg2HolidayEnd.MaxDate = DateTime.Today.AddMonths(1);

        }

        private void page3FlightsSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
        }

        private void page4HotelSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
        }

        private void page5CarSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
        }

        private void page6InsuranceSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
        }

        private void page7CheckDetailsSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = false;
        }

        private void page8SummarySetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
        }

        private void page9PaymentsSetup()
        {
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = false;
        }
        #endregion

        #region NAV BUTTONS
        //Start - Code for each of the nav buttons at the top of the page
        private void Navbtn1NewBooking_Click(object sender, EventArgs e)
        {
            NavIndex = 0;
            LoadPage();
        }

        private void Navbtn2Dates_Click(object sender, EventArgs e)
        {
            NavIndex = 1;
            LoadPage();
        }

        private void Navbtn3Flights_Click(object sender, EventArgs e)
        {
            NavIndex = 2;
            LoadPage();
        }

        private void Navbtn4Hotel_Click(object sender, EventArgs e)
        {
            NavIndex = 3;
            LoadPage();
        }

        private void Navbtn5Car_Click(object sender, EventArgs e)
        {
            NavIndex = 4;
            LoadPage();
        }

        private void Navbtn6Inusrance_Click(object sender, EventArgs e)
        {
            NavIndex = 5;
            LoadPage();
        }

        private void Navbtn7CheckDetails_Click(object sender, EventArgs e)
        {
            NavIndex = 6;
            LoadPage();
        }

        private void Navbtn8Summary_Click(object sender, EventArgs e)
        {
            NavIndex = 7;
            LoadPage();
        }

        private void Navbtn9Payments_Click(object sender, EventArgs e)
        {
            NavIndex = 8;
            LoadPage();
        }

        private void EnableNavButtons()
        {
            //Enables each of the navigation buttons at the top each time they are reached using the next buttons - Means no skip forward
            if (MaxNavIndex == 0)
            {Navbtn1NewBooking.Enabled = true;}
            else if (MaxNavIndex == 1)
            {Navbtn2Dates.Enabled = true; }
            else if (MaxNavIndex == 2)
            {Navbtn3Flights.Enabled = true; }
            else if (MaxNavIndex == 3)
            {Navbtn4Hotel.Enabled = true; }
            else if (MaxNavIndex == 4)
            {Navbtn5Car.Enabled = true; }
            else if (MaxNavIndex == 5)
            {Navbtn6Inusrance.Enabled = true; }
            else if (MaxNavIndex == 6)
            {Navbtn7CheckDetails.Enabled = true; }
            else if (MaxNavIndex == 7)
            {Navbtn8Summary.Enabled = true; }
            else if (MaxNavIndex == 8)
            {Navbtn9Payments.Enabled = true; }
        }

        #endregion
        
        #endregion

        #region PAGE 1 - GET LOCATION
        //********************************** Page 1 - Get location Buttons and functions ****************************************************
        private void cbPg1GetLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationID;
            int noOfAdults = 0;
            int noOfChildren = 0;

            locationID = cbPg1GetLocation.SelectedIndex;
            tbPg1NoOfAdults.Text = noOfAdults.ToString();
            tbPg1NoOfChildren.Text = noOfChildren.ToString();
        }

        private void btnPg1AddAdult_Click(object sender, EventArgs e)
        {
            tbPg1NoOfAdults.Text = (Convert.ToInt32(tbPg1NoOfAdults.Text)+1).ToString();
        }

        private void btnPg1MinusAdult_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPg1NoOfAdults.Text) > 0)
            {
                tbPg1NoOfAdults.Text = (Convert.ToInt32(tbPg1NoOfAdults.Text) - 1).ToString();
            }
        }

        private void btnPg1AddChild_Click(object sender, EventArgs e)
        {
            tbPg1NoOfChildren.Text = (Convert.ToInt32(tbPg1NoOfChildren.Text) + 1).ToString();
        }

        private void btnPg1MinusChild_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPg1NoOfChildren.Text) > 0)
            {
                tbPg1NoOfChildren.Text = (Convert.ToInt32(tbPg1NoOfChildren.Text) - 1).ToString();
            }
        }


        #endregion

        #region PAGE 2 - GET DATE
        //********************************** Page 2 - Get Date ****************************************************
        //http://geekswithblogs.net/dotNETvinz/archive/2009/03/09/tiptrick-aspnet-calendar-control-with-multiple-date-selections.aspx

        private void CalPg2HolidayDates_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dtPg2HolidayStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPg2HolidayEnd_ValueChanged(object sender, EventArgs e)
        {
            //CalPg2HolidayDates.SelectionRange = new SelectionRange(CurrentBooking.);
        }


        #endregion

        #region PAGE 3 - FLIGHTS
        //********************************** Page 3 - Flights ***************************************************************
        private void chbPg3YesFlights_CheckedChanged(object sender, EventArgs e)
        {
            chbPg3NoFlights.Checked = !chbPg3YesFlights.Checked;

            if (chbPg3YesFlights.Checked == true)
            {
                cbPg3DepartureAirport.Enabled = true;
                cbPg3TravelClass.Enabled = true;
            }
        }

        private void chbPg3NoFlights_CheckedChanged(object sender, EventArgs e)
        {
            chbPg3YesFlights.Checked = !chbPg3NoFlights.Checked;

            if (chbPg3NoFlights.Checked == true)
            {
                cbPg3DepartureAirport.Enabled = false;
                cbPg3TravelClass.Enabled = false;
            }
        }

        private void cbPg3DepartureAirport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPg3TravelClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #endregion

        #region PAGE 4 - HOTEL
        //********************************** Page 4 - Hotel ***************************************************************
        private void chbPg4YesHotel_CheckedChanged(object sender, EventArgs e)
        {
            chbPg4NoHotel.Checked = !chbPg4YesHotel.Checked;

            if (chbPg4YesHotel.Checked == true)
            {
                cbPg4SelectHotel.Enabled = true;
                calPg4HotelBooking.Enabled = true;
                dtPg4HotelStart.Enabled = true;
                dtPg4HotelEnd.Enabled = true;
            }
        }

        private void chbPg4NoHotel_CheckedChanged(object sender, EventArgs e)
        {
            chbPg4YesHotel.Checked = !chbPg4NoHotel.Checked;

            if (chbPg4NoHotel.Checked == true)
            {
                cbPg4SelectHotel.Enabled = false;
                calPg4HotelBooking.Enabled = false;
                dtPg4HotelStart.Enabled = false;
                dtPg4HotelEnd.Enabled = false;
            }
        }

        private void cbPg4SelectHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calPg4HotelBooking_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dtPg4HotelStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPg4HotelEnd_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region PAGE 5 - CAR
        //********************************** Page 5 - Car ***************************************************************
        private void chbPg5YesHireCar_CheckedChanged(object sender, EventArgs e)
        {
            chbPg5NoHireCar.Checked = !chbPg5YesHireCar.Checked;

            if (chbPg5YesHireCar.Checked == true)
            {
                cbPg5CarHireSelection.Enabled = true;
                dtPg5CarStartDate.Enabled = true;
                dtPg5CarEndDate.Enabled = true;
            }
        }

        private void chbPg5NoHireCar_CheckedChanged(object sender, EventArgs e)
        {
            chbPg5YesHireCar.Checked = !chbPg5NoHireCar.Checked;

            if (chbPg5NoHireCar.Checked == true)
            {
                cbPg5CarHireSelection.Enabled = false;
                dtPg5CarStartDate.Enabled = false;
                dtPg5CarEndDate.Enabled = false;
            }
        }

        private void cbPg5CarHireSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtPg5CarStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPg5CarEndDate_ValueChanged(object sender, EventArgs e)
        {

        }


        #endregion

        #region PAGE 6 - INSURANCE
        //********************************** Page 6 - Insurnace ***************************************************************

        private void chbPg6YesAddInsurance_CheckedChanged(object sender, EventArgs e)
        {
            chbPg6NoInsurance.Checked = !chbPg6YesInsurance.Checked;
        }

        private void chbPg6NoInsurance_CheckedChanged(object sender, EventArgs e)
        {
            chbPg6YesInsurance.Checked = !chbPg6NoInsurance.Checked;
        }


        #endregion

        #region PAGE 7 - CHECK DETAILS
        private void btnPg7ChangeDetails_Click(object sender, EventArgs e)
        {
            tbPg7FirstName.ReadOnly = false;
            tbPg7MiddleName.ReadOnly = false;
            tbPg7LastName.ReadOnly = false;
            tbPg7Phone.ReadOnly = false;
            tbPg7Email.ReadOnly = false;
            tbPg7HouseNo.ReadOnly = false;
            tbPg7Street.ReadOnly = false;
            tbPg7Town.ReadOnly = false;
            tbPg7Postcode.ReadOnly = false;
        }

        private void btnPg7CorrectDetails_Click(object sender, EventArgs e)
        {
            //Error checks for details
            NavIndex++;
            LoadPage();
        }
        #endregion

        #region PAGE 8 - SUMMARY

        #endregion

        #region PAGE 9 - PAYMENTS
        private void chbPg9BillingSameAsAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPg9BillingSameAsAccount.Checked == true)
            {
                //Fill in boxes with user details from account
                cbPg9Title.Enabled = false;
                mtbPg9FirstName.ReadOnly = true;
                mtbPg9LastName.ReadOnly = true;
                tbPg9HouseNo.ReadOnly = true;
                tbPg9Street.ReadOnly = true;
                tbPg9Town.ReadOnly = true;
                tbPg9Postcode.ReadOnly = true;
            }
            else if (chbPg9BillingSameAsAccount.Checked == false)
            {
                cbPg9Title.Enabled = true;
                mtbPg9FirstName.ReadOnly = false;
                mtbPg9LastName.ReadOnly = false;
                tbPg9HouseNo.ReadOnly = false;
                tbPg9Street.ReadOnly = false;
                tbPg9Town.ReadOnly = false;
                tbPg9Postcode.ReadOnly = false;
            }
        }

        private void chbPg9CreditCard_CheckedChanged(object sender, EventArgs e)
        {
            chbPg9DebitCard.Checked = !chbPg9CreditCard.Checked;
        }

        private void chbPg9DebitCard_CheckedChanged(object sender, EventArgs e)
        {
            chbPg9CreditCard.Checked = !chbPg9DebitCard.Checked;
        }

        private void btnPg9MakePayment_Click(object sender, EventArgs e)
        {
            //ADD ERROR CHECKS FOR CARD DETAILS
            Comfirmation comfirmation = new Comfirmation();
            comfirmation.Show();
            this.Hide();
        }
        #endregion

        /***********************************LIST OF THINGS TO ADD ***********************************************************************
       DONE - HIDE NEXT BUTTON ON CERTAIN PAGES EXAMPLE PAYMENT + CHECK DETAILS - DONE
       CHECK DETAILS = LOCK THE DATA IN TEXT BOXES UNLESS CHANGE DETAILS IS CLICKED
       iMPLEMENT CALANDER
       RUNNING TOTAL PRICE
       ADD IN BOOKED HOLIDAY OBJECT WHICH LOADS START AND ENDDATES OF HOLIDAYA BUT ALSO OF HOTELS
       ADD BASIC AND PREMIUM OPTION TO INSURANCE
       */
    }
}
