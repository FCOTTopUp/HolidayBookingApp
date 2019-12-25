using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class NewBooking: Booking
    {
        //Variables used for optional addons
        public bool WantFlights = true;
        public bool WantHotel = true;
        public bool WantCar = true;
        public bool WantInsurance = true;

        //Variables used for get location - Page 1
        int NoOfAdults;
        int NoOfChildren;

        //Variables for holiday dates inherited from booking class - Page 2

        //Variables used for flights - Page 3
        public int DepartureAirportID;
        public int TravelClassID;

        //Variables for hotel dates inherited from booking class - Page 4

        //Variables used for car hire - Page 5
        public int CarHireID;

        //Variables used for insurance - Page 6
        public int LocationSafetyRating;

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
            WantFlights = true;
            WantHotel = true;
            WantCar = true;
            WantInsurance = true;
        }
    }
}
