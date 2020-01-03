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
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Gets username and password from textboxes and call check login details
            CheckLoginDetails(tbUsername.Text, tbPassword.Text);
        }

        private void CheckLoginDetails(string _Username, string _Password)
        {
            //Currently hardcoded to check for a basic match 
            //NEED TO ADD ERROR CHECKS, NULLS AND EXTREMES
            //NEED TO ADD SQL CODE TO CHECK AGAINST DATABASE
            if (_Username == "test" && _Password == "test")
            {
                OpenMainPage(_Username);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: Incorrect Username or Password \nPlease try again");
            }
        }

        private void OpenMainPage(string _Username)
        {
            //Opens main form and hides the login page
            //NEED TO ADD FULLSCREEN CODE WHEN PAGES HAS BEEN FINASLISED
            MainForm MainForm = new MainForm(_Username);
            MainForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the app when the close button is clicked
            Application.Exit();
        }
    }
}
