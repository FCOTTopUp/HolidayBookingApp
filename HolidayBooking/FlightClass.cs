using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class FlightClass
    {
        int _FlightClassID;
        public string _FlightClassName { get; set; }
        int _FlightBasePrice { get; set; }

        public FlightClass(int FlightClassID, string FlightClassName, int FlightBasePrice)
        {
            _FlightClassID = FlightClassID;
            _FlightClassName = FlightClassName;
            _FlightBasePrice = FlightBasePrice;
        }
    }
}
