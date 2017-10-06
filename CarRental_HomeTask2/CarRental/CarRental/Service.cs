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
        protected ReservationsDB _reservationsDB;
        protected CarsDB _carsDB;
        protected byte maxNumberOfDaysReservation;
    }   
}
