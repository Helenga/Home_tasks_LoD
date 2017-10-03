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
            
        }

        public void ReserveThisCar(Car car)
        {
            
        }

        public string FIO { get; set; }
    }
}
