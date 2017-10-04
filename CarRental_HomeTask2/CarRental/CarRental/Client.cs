using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Client
    {
        IClientFunctions service = new Service();

        public IEnumerable<Car> FindCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            return service.GetAllAvailableCars(firstDayOfReservation, lastDayOfReservation);
        }

        public Car ChoseCarToReserve()
        {

        }

        public void ReserveChoosenCar(Car car)
        {
            // послать фио и выбранную машину в сервис
        }

        public string FIO { get; set; }
    }
}
