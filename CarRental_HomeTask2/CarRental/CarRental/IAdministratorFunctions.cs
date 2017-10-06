using System;
using System.Collections.Generic;

namespace CarRental
{
    public interface IAdministratorFunctions
    {
        IEnumerable<Car> GetAllCars();

        void AddCar(int id, string model, string color);
    }
}
