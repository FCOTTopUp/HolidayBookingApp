using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class HotelInfo
    {
        int _HotelID;
        public string _HotelName { get; set; }
        int _Rating;

        List<HotelRooms> RoomsInHotel = new List<HotelRooms>();

        public HotelInfo(int HotelId, string HotelName, int Rating)
        {
            _HotelID = HotelId;
            _HotelName = HotelName;
            _Rating = Rating;
        }

        public void LoadRoomInfo()
        {
            //Updates rooms in hotel list
        }
        //Other info
    }
}
