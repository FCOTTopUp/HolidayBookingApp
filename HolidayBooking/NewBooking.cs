using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class NewBooking: Booking
    {
        int NoOfAdults;
        int NoOfChildren;

        public NewBooking()
        {
        }

        public void SetupBooking(int _locationID, int _NoOfAdults, int _NoOfChildren)
        {
            Clear();
            LocationID = _locationID;
            NoOfAdults = _NoOfAdults;
            NoOfChildren = _NoOfChildren;
        }


        public void Clear()
        {
            holidayStartDate = DateTime.Today;
            holidayEndDate = DateTime.Today;
            LengthOfHoliday = 0;
            LocationID = 0;
        }
        //customer details
    }
}
