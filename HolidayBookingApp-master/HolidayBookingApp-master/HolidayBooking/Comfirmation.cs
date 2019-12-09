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
    public partial class Comfirmation : Form
    {
        public Comfirmation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            //TO ADD CODE TO ALSO CLOSE MAINFORM AND THEN SHOW LOGIN FORM AGAIN
            this.Close();

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            //TO ADD CODE TO SHOW MAIN FORM AGAIN
            this.Close();
        }
    }
}
