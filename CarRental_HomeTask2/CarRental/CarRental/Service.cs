using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Service
    {
        public void AddNewCar(Car car)
        {
            string _model = "";
            string _color = "";
            int _id = 0;
            OccupationStatus _status = OccupationStatus.Free;
            // реализовать получение параметров

            Car newCar = new Car(_id, _model, _color, _status); 
            AllCars.ToList<Car>().Add(newCar);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return AllCars;
        }


        // функции для обработки событий клиента
        // функции для обработки событий админа

        public IEnumerable<Car> AllCars { get; private set; }

        private Dictionary<Client, Car> _reservedCars;
    }
}
