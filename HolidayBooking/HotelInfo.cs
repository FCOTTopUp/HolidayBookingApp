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

        public int _DoubleRoomsMax { get; set; }
        public int _FamilyRoomsMax { get; set; }
        public int _TwinRoomsMax { get; set; }

        int _BookedDouble = 0;
        int _BookedFamily = 0;
        int _BookedTwin = 0;

        //public List<HotelRooms> RoomsInHotel = new List<HotelRooms>();
        //TO add later on instead of hard coding room types

        public HotelInfo(int HotelId, string HotelName, int Rating, int DoubleRooms, int TwinRooms, int FamilyRooms)
        {
            _HotelID = HotelId;
            _HotelName = HotelName;
            _Rating = Rating;
            _DoubleRoomsMax = DoubleRooms;
            _FamilyRoomsMax = FamilyRooms;
            _TwinRoomsMax = TwinRooms;
        }

        /*public void LoadRoomInfo()
        {
            //Updates rooms in hotel list
            //Currently just has test data
            RoomsInHotel.Add(new HotelRooms(0, "Double", 100, 5));
            RoomsInHotel.Add(new HotelRooms(1, "Twin", 100, 4));
            RoomsInHotel.Add(new HotelRooms(2, "Family", 100, 3));
        }
        */
        //Other info
    }
}
