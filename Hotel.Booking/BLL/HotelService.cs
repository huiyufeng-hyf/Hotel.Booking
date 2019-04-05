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

        protected List<Order> BookedList;

        public HotelService(string name, int level, int rooms)
        {
            HotelName = name;
            HotelLevel = level;
            TotalRooms = rooms;
            BookedList = new List<Order>();
        }
        public BookingResult BookHotel(Order item)
        {
            BookingResult res = new BookingResult();

            int leftRooms = CalcLeftRooms(item);
            if (item.RoomCount > leftRooms)
            {
                res.IsValid = false;
                return res;
            }

            res.ClientName = item.ClientName;
            res.HotelName = item.HotelName;
            res.BookingCount = item.RoomCount;
            res.IsValid = true;

            BookedList.Add(item);

            return res;
        }

        public int CalcLeftRooms(Order item)
        {
            List<Order> existingOrderList = BookedList.Where(o => item.CheckInDate <= o.CheckOutDate
            && o.HotelName.Equals(item.HotelName, StringComparison.CurrentCultureIgnoreCase)).ToList();
            if (existingOrderList != null)
            {
                return TotalRooms - existingOrderList.Sum(o => o.RoomCount);
            }
            else
            {
                return TotalRooms;
            }
        }
    }
}
