using System;
using System.Collections.Generic;

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

        public IEnumerable<Car> GetAllAvailableCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            if (firstDayOfReservation.AddDays(1) <= lastDayOfReservation && firstDayOfReservation.AddDays(59) < lastDayOfReservation)
            {
                return _carsDB.SelectCarsWhichAvailableIn(firstDayOfReservation, lastDayOfReservation);
            }
            else
            {
                throw new ArgumentException("Passed dates are not valid");
            }
        }

        public void ReserveChoosenCar(Client client, Car car)
        {
            if (!_reservationDB.DoesClientHaveReservation(client))
            {
                _reservationDB.ReservedCars.Add(client, car);
            }
            else
            {
                throw new Exception("The client already has a reservation");
            }
        }
    }
}
