using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Booking.Model;

namespace Hotel.Booking.DAL
{
    public class OrderDal : IDal
    {
        private string _filePath;

        public OrderDal(string filePath)
        {
            _filePath = filePath;
        }
        public List<Order> GetOrders()
        {
            List<Order> orderList = new List<Order>();
            if (!File.Exists(_filePath))
            {
                return orderList;
            }

            FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);

            string lineContent = string.Empty;
            while ((lineContent = sr.ReadLine()) != null)
            {
                string[] orderData = lineContent.Split(' ');
                Order newItem = new Order
                {
                    ClientName = orderData[0],
                    HotelName = orderData[1],
                    CheckInDate = Convert.ToDateTime(orderData[2]),
                    CheckOutDate = Convert.ToDateTime(orderData[3]),
                    RoomCount = Convert.ToInt32(orderData[4])
                };

                orderList.Add(newItem);
            }

            return orderList;
        }
    }
}
