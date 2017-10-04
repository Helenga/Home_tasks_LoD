using System;
using System.Collections.Generic;

namespace CarRental
{
    class Client
    {
        IClientFunctions service = new Service();

        public IEnumerable<Car> FindCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            return service.GetAllAvailableCars(firstDayOfReservation, lastDayOfReservation);
        }

        public void ReserveChoosenCar(Car car)
        {
            service.ReserveChoosenCar(this, car);
        }

        public string FIO { get; set; }
    }
}
