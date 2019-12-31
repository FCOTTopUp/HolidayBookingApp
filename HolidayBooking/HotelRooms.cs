using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayBooking
{
    class HotelRooms
    {

        int _RoomID { get; set; }
        public string _RoomTypeName { get; set; }
        int _Price { get; set; }
        int _TotalRooms { get; set; }
        int _RoomsLeft { get; set; }

        public HotelRooms(int RoomID, string RoomTypeName, int Rating, int TotalRooms)
        {
            _RoomID = RoomID;
            _RoomTypeName = RoomTypeName;
            _Price = Rating;
            _TotalRooms = TotalRooms;
        }
    }
}
