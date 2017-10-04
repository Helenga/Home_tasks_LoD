using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    interface IClientFunctions
    {
        IEnumerable<Car> GetAllAvailableCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation);

        void ReserveChoosenCar(Client client, Car car);
    }
}
