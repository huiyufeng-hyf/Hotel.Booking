using Hotel.Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Booking.BLL
{
    public interface IService
    {
        BookingResult BookHotel(Order item);
        int CalcLeftRooms(Order item);
    }
}
