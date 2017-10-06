using System;
using System.Collections.Generic;

namespace CarRental
{
    class CarsDB
    {
        private static List<Car> _allCars; // одинаковый для любого экземпляра сервиса

        public IEnumerable<Car> ReturnListOfCars()
        {
            return _allCars;
        }

        public void AddNewCar(int id, string model, string color)
        {
            Car car = new Car(id, model, color);
            _allCars.Add(car);
        }

        public IEnumerable<Car> SelectCarsWhichAvailableIn(DateTime firstDay, DateTime lastDay)
        {
            List<Car> AvailableCars = new List<Car>();
            ReservationsDB reservationsDB = new ReservationsDB();
            foreach (Car car in _allCars)
            {
                if (reservationsDB.IsFreeToRentIn(firstDay, lastDay))
                {
                    AvailableCars.Add(car);
                }
            }
            return AvailableCars;
        }

        public void RefreshCarStatus(int id)
        {
            _allCars.Find(car => car.ID == id).CheckStatus();
        }
    }
}
