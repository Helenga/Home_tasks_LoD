using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Administrator
    {
        IAdministratorFunctions service = new Service();

        public void CreateAddCarQuery(int id, string model, string color)
        {
            service.AddCar(id, model, color);
        }

        public IEnumerable<Car> CreateGetAllCarsQuery()
        {
            return service.GetAllCars();
        }

        private string _accessKey { get; } // ключ доступа
    }
}
