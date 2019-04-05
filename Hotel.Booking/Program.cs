using Hotel.Booking.BLL;
using Hotel.Booking.DAL;
using Hotel.Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\Data\OrderList.txt";

            IDal dal = new OrderDal(filePath);
            List<Order> orderList = dal.GetOrders();
            Console.WriteLine(orderList.Count);
            Console.WriteLine("========staring to booking hotel now.===========");

            HotelService jwSvc = new JWHotelSvc("JW", 5, 400);
            HotelService jxSvc = new JXHotelSvc("JX", 4, 450);
            HotelService jySvc = new JYHotelSvc("JY", 3, 500);
            HotelService jzSvc = new JZHotelSvc("JZ", 2, 420);

            List<BookingResult> brList = new List<BookingResult>();
            //BookingResult bookingRes = null;
            foreach (Order item in orderList)
            {
                if (item.HotelName.Equals("JW", StringComparison.CurrentCultureIgnoreCase))
                {
                    //bookingRes = jwSvc.BookHotel(item);
                    brList.Add(jwSvc.BookHotel(item));
                }
                else if (item.HotelName.Equals("JX", StringComparison.CurrentCultureIgnoreCase))
                {
                    //bookingRes = jxSvc.BookHotel(item);
                    brList.Add(jxSvc.BookHotel(item));
                }
                else if (item.HotelName.Equals("JY", StringComparison.CurrentCultureIgnoreCase))
                {
                    //bookingRes = jySvc.BookHotel(item);
                    brList.Add(jySvc.BookHotel(item));
                }
                else if (item.HotelName.Equals("JZ", StringComparison.CurrentCultureIgnoreCase))
                {
                    //bookingRes = jzSvc.BookHotel(item);
                    brList.Add(jzSvc.BookHotel(item));
                }

                //if (bookingRes.IsValid)
                //{
                //    Console.WriteLine(string.Format("{0} {1} {2}", bookingRes.ClientName, bookingRes.HotelName, bookingRes.BookingCount));
                //}
                //else
                //{
                //    Console.WriteLine("Invalid");
                //}
            }

            DisplayResult(brList);


            Console.ReadLine();
        }

        private static void DisplayResult(List<BookingResult> bookingRes)
        {
            if (bookingRes == null)
            {
                return;
            }

            BookingResult br = bookingRes.Where(r => !r.IsValid).FirstOrDefault();
            if (br != null)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                foreach (BookingResult item in bookingRes)
                {
                    Console.WriteLine(string.Format("{0} {1} {2}", item.ClientName, item.HotelName, item.BookingCount));
                }
            }
        }

    }
}
