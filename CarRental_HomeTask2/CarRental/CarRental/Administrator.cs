using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Administrator : IAdministratorFunctions
    {
        public void AddCar(Car car)
        {

        }

        public IEnumerable<Car> GetAllCars()
        {

        }

        private string _accessKey { get; } // ключ доступа
    }
}
