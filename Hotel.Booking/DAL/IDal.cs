using Hotel.Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Booking.DAL
{
    public interface IDal
    {
        List<Order> GetOrders();
    }
}
