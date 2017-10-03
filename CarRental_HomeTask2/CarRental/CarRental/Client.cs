using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Client : IClientFunctions
    {
        public IEnumerable<Car> GetAllAvailableCars(DateTime dateOfReservation)
        {
            // делает запрос к сервису
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
