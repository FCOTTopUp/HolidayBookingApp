using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class NewBooking: Booking
    {



        public void Clear()
        {
            startdate = DateTime.Today;
            endDate = DateTime.Today;
            LengthOfHoliday = 0;
            Location = null;
        }
        //customer details
    }
}
