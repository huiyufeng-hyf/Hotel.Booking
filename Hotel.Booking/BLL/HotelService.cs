using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Booking.Model;

namespace Hotel.Booking.BLL
{
    public abstract class HotelService : IService
    {
        protected string HotelName;
        protected int HotelLevel;
        protected int TotalRooms;
        protected int LeftRooms;

        protected List<BookingResult> BookedList;

        public HotelService(string name, int level, int rooms)
        {
            HotelName = name;
            HotelLevel = level;
            TotalRooms = rooms;
            LeftRooms = rooms;
            BookedList = new List<BookingResult>();
        }
        public BookingResult BookHotel(Order item)
        {
            BookingResult res = new BookingResult();

            if (BookedList.Count <= 0)
            {
                if (item.RoomCount > LeftRooms)
                {
                    res.IsValid = false;
                    return res;
                }
            }
            

            res.ClientName = item.ClientName;
            res.HotelName = item.HotelName;
            res.BookingCount = item.RoomCount;
            res.IsValid = true;

            CalcLeftRooms(item);

            return res;
        }

        public void CalcLeftRooms(Order item)
        {
            LeftRooms -= item.RoomCount;
        }
    }
}
