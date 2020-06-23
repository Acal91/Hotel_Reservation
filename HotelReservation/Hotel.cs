using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Hotel
    {
        private Room[] rooms = new Room[1000];

        public Room[] Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        private int roomSize;

        public int RoomSize
        {
            get { return roomSize; }
            set { roomSize = value; }
        }


        public Hotel(int roomSize)
        {
            RoomSize = roomSize;

            for (int i = 0; i < roomSize; i++)
            {
                Rooms[i] = new Room();
            }
        }

       
        public void dodajSobu()
        {
            Rooms[RoomSize] = new Room();
            RoomSize++;
        }

        public bool rezervisi(int startDate, int endDate)
        {
            if (startDate >= 0 && endDate <= 365)
            {
                for (int i = 0; i < RoomSize; i++)
                {
                    bool nasaoSlobodnu = true;
                    for (int j = startDate; j <= endDate; j++)
                    {
                        if (this.Rooms[i].Rezervacije[j] == true)
                        {
                            nasaoSlobodnu = false;
                        }
                    }
                    if (nasaoSlobodnu)
                    {
                        for (int j = startDate; j <= endDate; j++)
                        {
                            this.Rooms[i].Rezervacije[j] = true;

                        }
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
