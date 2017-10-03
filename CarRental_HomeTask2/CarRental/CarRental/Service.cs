using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Service : IAdministratorFunctions
    {
        public void AddNewCar(Car car)
        {
            AllCars.ToList<Car>().Add(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return AllCars;
        }

        public IEnumerable<Car> AllCars { get; private set; }

        private Dictionary<Client, Car> _reservedCars;
    }
}
