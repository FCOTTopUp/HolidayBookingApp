using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class Booking
    {
        //Parent class for new booking and exsisting booking holding shared variables
        protected int bookingid;

        protected DateTime holidayStartDate;
        protected DateTime holidayEndDate;
        protected int LengthOfHoliday;
        protected int LocationID;
    }
}
