using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel(2);
            bool booking1 = hotel.rezervisi(1, 3);
            bool booking2 = hotel.rezervisi(0, 4);
            bool booking3 = hotel.rezervisi(2, 3);
            bool booking4 = hotel.rezervisi(5, 5);
            bool booking5 = hotel.rezervisi(4, 10);
            bool booking6 = hotel.rezervisi(10, 10);
            bool booking7 = hotel.rezervisi(6, 7);
            bool booking8 = hotel.rezervisi(8, 10);
            bool booking9 = hotel.rezervisi(8, 9);
            Console.WriteLine(booking1);
            Console.WriteLine(booking2);
            Console.WriteLine(booking3);
            Console.WriteLine(booking4);
            Console.WriteLine(booking5);
            Console.WriteLine(booking6);
            Console.WriteLine(booking7);
            Console.WriteLine(booking8);
            Console.WriteLine(booking9);

            Console.ReadLine();
        }
    }
}
