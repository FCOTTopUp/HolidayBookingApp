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
        List<Panel> NavPanels = new List<Panel>();
        int NavIndex;



        public MainForm()
        {
            InitializeComponent();
        }

        //********************************** General Buttons and functions ****************************************************
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Adds all the panels to a list on start up so nav code can flip through them abnd resets index
            NavIndex = 0;
            NavPanels.Add(plGetLocation);
            NavPanels.Add(plBookingDates);
            NavPanels.Add(plFlight);
            NavPanels.Add(plHotel);
            NavPanels.Add(plCarHire);
            NavPanels.Add(plInsurance);
            NavPanels.Add(plCheckDetails);
            NavPanels.Add(plSummary);
            NavPanels.Add(plPayment);
            LoadPage(NavIndex);
            updateProgressBar(NavIndex);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the Application
            //TO ADD GIVE THE OPTION OF LOG OUT ONLY
            Application.Exit();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            //takes user back one page in navigation
            if (NavIndex > 0)
                NavPanels[--NavIndex].BringToFront();
            updateProgressBar(NavIndex);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            //Takes user to next page in navigation
            if (NavIndex < NavPanels.Count - 1)
            {
                NavPanels[++NavIndex].BringToFront();
                updateProgressBar(NavIndex);
            }
            else if (NavIndex ==8)
            {
                Comfirmation comfirmation = new Comfirmation();
                comfirmation.Show();
                this.Hide();
            }
        }

        private void LoadPage(int _NavIndex)
        {
            NavPanels[NavIndex].BringToFront();
            updateProgressBar(_NavIndex);
        }


        private void updateProgressBar(int _NavIndex)
        {
            //Updates progress bar form the use of the nav index
            BookingProgressBar.Value = ((_NavIndex +1) * 10);
        }

        private void Navbtn1NewBooking_Click(object sender, EventArgs e)
        {
            NavIndex = 0;
            LoadPage(NavIndex);
        }

        private void Navbtn2Dates_Click(object sender, EventArgs e)
        {
            NavIndex = 1;
            LoadPage(NavIndex);
        }

        private void Navbtn3Flights_Click(object sender, EventArgs e)
        {
            NavIndex = 2;
            LoadPage(NavIndex);
        }

        private void Navbtn4Hotel_Click(object sender, EventArgs e)
        {
            NavIndex = 3;
            LoadPage(NavIndex);
        }

        private void Navbtn5Car_Click(object sender, EventArgs e)
        {
            NavIndex = 4;
            LoadPage(NavIndex);
        }

        private void Navbtn6Inusrance_Click(object sender, EventArgs e)
        {
            NavIndex = 5;
            LoadPage(NavIndex);
        }

        private void Navbtn7CheckDetails_Click(object sender, EventArgs e)
        {
            NavIndex = 6;
            LoadPage(NavIndex);
        }

        private void Navbtn8Summary_Click(object sender, EventArgs e)
        {
            NavIndex = 7;
            LoadPage(NavIndex);
        }

        private void Navbtn9Payments_Click(object sender, EventArgs e)
        {
            NavIndex = 8;
            LoadPage(NavIndex);
        }

        //********************************** Page 1 - Get location Buttons and functions ****************************************************

        private void cbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        //********************************** Page 2 - Get Dates Buttons and functions ****************************************************







        /***********************************LIST OF THINGS TO ADD ***********************************************************************
       HIDE NEXT BUTTON ON CERTAIN PAGES EXAMPLE PAYMENT
       iMPLEMENT CALANDER


       */
    }
}
