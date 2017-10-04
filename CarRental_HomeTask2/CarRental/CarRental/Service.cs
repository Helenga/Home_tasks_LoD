using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Service : IAdministratorFunctions, IClientFunctions
    {
        ReservationsDB _reservationDB;
        CarsDB _carsDB;

        //IAdministratorFunctions
        public void AddCar(int id, string model, string color)
        {
            _carsDB.AddNewCar(id, model, color);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carsDB.AllCars;
        }

        // IClientFunctions
        public Car ChoseCarToReserve()
        {
            
        }

        // min = 1 day, max = 60 days
        public IEnumerable<Car> GetAllAvailableCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            if (AreDatesValid(firstDayOfReservation, lastDayOfReservation))
            {
                return _carsDB.SelectCarsWhichAvailableIn(firstDayOfReservation, lastDayOfReservation);
            }
            else
            {
                throw new ArgumentException("Passed dates are not valid");
            }
        }

        public void ReserveChoosenCar(Car car)
        {
            
        }

        public bool AreDatesValid (DateTime firstDay, DateTime lastDay)
        {
            return firstDay.AddDays(1) <= lastDay  && firstDay.AddDays(59) < lastDay;
        }
    }
}
