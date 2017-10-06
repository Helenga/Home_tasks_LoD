using System;
using System.Collections.Generic;

namespace CarRental
{
    public class Administrator
    {
        public Administrator()
        {
            service = new AdministratorService();
        }
        IAdministratorFunctions service;

        public void CreateAddCarQuery(int id, string model, string color)
        {
            service.AddCar(id, model, color);
        }

        public IEnumerable<Car> CreateGetAllCarsQuery()
        {
            return service.GetAllCars();
        }
    }
}
