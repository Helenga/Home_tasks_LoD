using System;

namespace CarRental
{
    public class Reservation
    {
        public Reservation(string renter, int carID, DateTime unavailableFrom, DateTime unavailableTo)
        {
            Renter = renter;
            CarID = carID;
            UnavailableFrom = unavailableFrom;
            UnavailableTo = unavailableTo;
        }
        public string Renter;
        public int CarID;
        public DateTime UnavailableFrom;
        public DateTime UnavailableTo;
    }
}
