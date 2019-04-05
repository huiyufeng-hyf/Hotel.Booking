using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Booking.BLL
{
    public class JZHotelSvc : HotelService
    {
        public JZHotelSvc(string name, int level, int rooms) : base(name, level, rooms)
        {
        }
    }
}
