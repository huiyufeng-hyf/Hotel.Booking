using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Booking.BLL
{
    public class JWHotelSvc : HotelService
    {
        public JWHotelSvc(string name, int level, int rooms) : base(name, level, rooms)
        {
        }
    }
}
