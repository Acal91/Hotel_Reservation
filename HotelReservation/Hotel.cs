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
                for (int i = 0; i < RoomSize; i++) //prolazimo kroz sve postojece sobe u hotelu
                {
                    bool nasaoSlobodnu = true;
                    for (int j = startDate; j <= endDate; j++) // proveravamo da li je soba slobodna u zadatom opsegu dana
                    {
                        if (this.Rooms[i].Rezervacije[j] == true) //Ukoliko je vrednost true, znaci da je soba taj dan zauzeta
                                nasaoSlobodnu = false; 
                        
                    }
                    if (nasaoSlobodnu) //ako nadjemo slobodnu sobu
                    {
                        for (int j = startDate; j <= endDate; j++)
                        {
                            this.Rooms[i].Rezervacije[j] = true; //Postavljamo vrednost na true(zauzimamo dane u toj sobi, za zadati datum)

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
