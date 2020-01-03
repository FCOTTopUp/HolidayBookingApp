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
        public int NoOfAdults;
        public int NoOfChildren;

        //Variables for holiday dates inherited from booking class - Page 2

        //Variables used for flights - Page 3
        public int DepartureAirportID;
        public int TravelClassID;

        //Variables for hotel dates inherited from booking class - Page 4

        //Variables used for car hire - Page 5
        public int CarHireID;

        //Variables used for insurance - Page 6
        public int LocationSafetyRating;

        //Customer Details
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string PhoneNo;
        public string Email;
        public string HouseNo;
        public string Street;
        public string Town;
        public string Postcode;

        //Customer Billing Details
        public string BillingFirstName;
        public string BillingLastName;
        public string BillingHouseNo;
        public string BillingStreet;
        public string BillingTown;
        public string BillingPostcode;

        //Customer Payment infomation
        public bool CreditCard;
        public bool DebitCard;
        public string NameOnCard;
        public string CardNo;
        public string CardExpiry;
        public string CardSercuityCode;

        //Temporary Vairables used for summary for user
        public string LocationName;
        public string DepartureAirportName;
        public string TravelClassName;
        public string CarHireName;
        public string HotelName;

        public NewBooking()
        {
            CreditCard = false;
            DebitCard = true;
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

        public void BillingSameAsAccount()
        {
            BillingFirstName = FirstName;
            //BillingMiddleName = MiddleName;
            BillingLastName = LastName;
            BillingHouseNo = HouseNo;
            BillingStreet = Street;
            BillingTown = Town;
            BillingPostcode = Postcode;
        }
    }
}
