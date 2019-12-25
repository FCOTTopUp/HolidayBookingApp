using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class CarTypes
    {
        public int _CarTypeID;
        public string _CarTypeName { get; set; }
        public int _CarHireBasePrice;

        public CarTypes(int CarTypeID, string CarTypeName, int CarHireBasePrice)
        {
            _CarTypeID = CarTypeID;
            _CarTypeName = CarTypeName;
            _CarHireBasePrice = CarHireBasePrice;
        }
    }
}
