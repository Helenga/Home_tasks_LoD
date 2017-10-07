using Newtonsoft.Json;

namespace CarRental
{
    public class Service
    {
        public Service()
        {
            _reservationsDB = new ReservationsDB();
            _carsDB = new CarsDB();
            maxNumberOfDaysReservation = 60;
        }
        [JsonProperty]
        protected ReservationsDB _reservationsDB;
        [JsonProperty]
        protected CarsDB _carsDB;
        [JsonProperty]
        protected byte maxNumberOfDaysReservation;
    }   
}
