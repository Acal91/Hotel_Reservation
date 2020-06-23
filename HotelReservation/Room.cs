using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Room
    {
        private const int maxSize = 365;
        private Boolean[] rezervacije = new Boolean[maxSize];

        public Boolean[] Rezervacije
        {
            get { return rezervacije; }
            set { rezervacije = value; }
        }

        public Room()
        {
            for (int i = 0; i < rezervacije.Length; i++)
            {
                rezervacije[i] = false;
            }
        }
    }
}
