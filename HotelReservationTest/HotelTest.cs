using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation;

namespace HotelReservationTest
{
    [TestClass]
    public class HotelTest
    {
        [TestMethod]
        public void TestMethodOne()
        {
            Hotel hotel = new Hotel(1);
            bool booking1 = hotel.rezervisi(-4,2);
            bool booking2 = hotel.rezervisi(200, 400);

            Assert.AreEqual(false, booking1);
            Assert.AreEqual(false, booking2);

        }

        [TestMethod]
        public void TestMethodTwo()
        {
            Hotel hotel = new Hotel(3);
            bool booking1 = hotel.rezervisi(0, 5);
            bool booking2 = hotel.rezervisi(7, 13);
            bool booking3 = hotel.rezervisi(3, 9);
            bool booking4 = hotel.rezervisi(5, 7);
            bool booking5 = hotel.rezervisi(6, 6);
            bool booking6 = hotel.rezervisi(0, 4);

            Assert.AreEqual(true, booking1);
            Assert.AreEqual(true, booking2);
            Assert.AreEqual(true, booking3);
            Assert.AreEqual(true, booking4);
            Assert.AreEqual(true, booking5);
            Assert.AreEqual(true, booking6);

        }

        [TestMethod]
        public void TestMethodThree()
        {
            Hotel hotel = new Hotel(3);
            bool booking1 = hotel.rezervisi(1, 3);
            bool booking2 = hotel.rezervisi(2, 5);
            bool booking3 = hotel.rezervisi(1, 9);
            bool booking4 = hotel.rezervisi(0, 15);

            Assert.AreEqual(true, booking1);
            Assert.AreEqual(true, booking2);
            Assert.AreEqual(true, booking3);
            Assert.AreEqual(false, booking4);

        }

        [TestMethod]
        public void TestMethodFour()
        {
            Hotel hotel = new Hotel(3);
            bool booking1 = hotel.rezervisi(1, 3);
            bool booking2 = hotel.rezervisi(0, 15);
            bool booking3 = hotel.rezervisi(1, 9);
            bool booking4 = hotel.rezervisi(2, 5);
            bool booking5 = hotel.rezervisi(4, 9);

            Assert.AreEqual(true, booking1);
            Assert.AreEqual(true, booking2);
            Assert.AreEqual(true, booking3);
            Assert.AreEqual(false, booking4);
            Assert.AreEqual(true, booking5);

        }

        [TestMethod]
        public void TestMethodFive()
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

            Assert.AreEqual(true, booking1);
            Assert.AreEqual(true, booking2);
            Assert.AreEqual(false, booking3);
            Assert.AreEqual(true, booking4);
            Assert.AreEqual(false, booking5);
            Assert.AreEqual(true, booking6);
            Assert.AreEqual(true, booking7);
            Assert.AreEqual(true, booking8);
            Assert.AreEqual(true, booking9);
            

        }


    }
}
