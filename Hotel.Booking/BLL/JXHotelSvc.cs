using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Booking.BLL
{
    public class JXHotelSvc : HotelService
    {
        public JXHotelSvc(string name, int level, int rooms) : base(name, level, rooms)
        {
        }
    }
}
