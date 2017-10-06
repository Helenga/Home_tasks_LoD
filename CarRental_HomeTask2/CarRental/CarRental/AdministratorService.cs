using System;
using System.Collections.Generic;

namespace CarRental
{
    class AdministratorService : Service, IAdministratorFunctions
    {
        public void AddCar(int id, string model, string color)
        {
            _carsDB.AddNewCar(id, model, color);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carsDB.ReturnListOfCars();
        }
    }
}
