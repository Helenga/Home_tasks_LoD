using System;
using Newtonsoft.Json;

namespace CarRental
{
    public class Reservation
    {
        public Reservation(string renter, int carID, 
                           DateTime unavailableFrom, DateTime unavailableTo)
        {
            Renter = renter;
            CarID = carID;
            UnavailableFrom = unavailableFrom;
            UnavailableTo = unavailableTo;
        }
        [JsonProperty]
        public string Renter;
        [JsonProperty]
        public int CarID;
        [JsonProperty]
        public DateTime UnavailableFrom;
        [JsonProperty]
        public DateTime UnavailableTo;
    }
}
