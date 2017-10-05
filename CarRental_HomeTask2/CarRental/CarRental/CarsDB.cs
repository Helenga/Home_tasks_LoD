using System;
using System.Collections.Generic;

namespace CarRental
{
    abstract class CarsDB
    {
        public List<Car> AllCars { get; private set; }

        public void AddNewCar(int id, string model, string color)
        {
            Car car = new Car(id, model, color);
            AllCars.Add(car);
        }

        public IEnumerable<Car> SelectCarsWhichAvailableIn(DateTime firstDay, DateTime lastDay)
        {
            List<Car> AvailableCars = new List<Car>();
            foreach (Car car in AllCars)
            {
                if (car.IsFreeToRentIn(firstDay, lastDay))
                {
                    AvailableCars.Add(car);
                }
            }
            return AvailableCars;
        }
    }
}
