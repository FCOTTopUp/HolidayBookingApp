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
        public int bookingid;

        public DateTime holidayStartDate;
        public DateTime holidayEndDate;
        public int LengthOfHoliday;
        public int LocationID;

        public int HotelID;
        public DateTime HotelStartDate;
        public DateTime HotelEndDate;

        public int HotelDoubleRoomsRequired;
        public int HotelFamilyRoomsRequired;
        public int HotelTwinRoomsRequired;
    }
}
