using System;
using System.Collections.Generic;
using Exceptions;
using Newtonsoft.Json;

namespace CarRental
{
    public class CarsDB
    {
        [JsonProperty]
        private static List<Car> _allCars; // одинаковый для любого экземпляра сервиса

        static CarsDB()
        {
            _allCars = new List<Car>();
        }

        public IEnumerable<Car> ReturnListOfCars()
        {
            return _allCars;
        }

        public void AddNewCar(int id, string model, string color)
        {
            if (IsIdUnique(id))
            {
                Car car = new Car(id, model, color);
                _allCars.Add(car);
            }
            else
            {
                throw new CarIDAleradyExists();
            }
        }

        public IEnumerable<Car> SelectCarsWhichAvailableIn(DateTime firstDay, DateTime lastDay)
        {
            List<Car> AvailableCars = new List<Car>();
            ReservationsDB reservationsDB = new ReservationsDB();
            foreach (Car car in _allCars)
            {
                if (reservationsDB.IsFreeToRentIn(car.ID, firstDay, lastDay))
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

        private bool IsIdUnique(int carID)
        {
            return !_allCars.Exists(car => car.ID == carID);
        }
    }
}
