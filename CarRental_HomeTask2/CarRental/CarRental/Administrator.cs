using System;
using System.Collections.Generic;

namespace CarRental
{
    class Administrator
    {
        IAdministratorFunctions service = new AdministratorService();

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
