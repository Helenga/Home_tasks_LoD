namespace CarRental
{
    class Service
    {
        protected ReservationsDB _reservationsDB = new ReservationsDB();
        protected CarsDB _carsDB = new CarsDB();
        protected byte maxNumberOfDaysReservation = 60;
    }   
}
