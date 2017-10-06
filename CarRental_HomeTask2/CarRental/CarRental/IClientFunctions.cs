using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental
{
    public interface IClientFunctions
    {
        IEnumerable<Car> GetAllAvailableCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation);

        void ReserveChoosenCar(string clientName, int carID, DateTime firstDayOfReservation, DateTime lastDayOfReservation);
    }
}
