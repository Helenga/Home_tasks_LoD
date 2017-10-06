using System;
using System.Collections.Generic;

namespace CarRental
{
    class ClientService : Service, IClientFunctions
    {
        public IEnumerable<Car> GetAllAvailableCars(DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            if (IsNumberOfDaysLessThanMaximumTerm(firstDayOfReservation, lastDayOfReservation))
            {
                return _carsDB.SelectCarsWhichAvailableIn(firstDayOfReservation, lastDayOfReservation);
            }
            else
            {
                throw new ArgumentException("Passed dates are not valid");
            }
        }

        public void ReserveChoosenCar(string clientName, int carID, DateTime from, DateTime to)
        {
            if (!_reservationsDB.DoesClientHaveReservation(clientName))
            {
                if (_reservationsDB.IsFreeToRentIn(from, to))
                {
                    _reservationsDB.AddReservation(clientName, carID, from, to);
                    _carsDB.RefreshCarStatus(carID);
                }
                else
                {
                    throw new Exception("The car is unavailable during this time");
                }
            }
            else
            {
                throw new Exception("The client already has a reservation");
            }
        }

        private bool IsNumberOfDaysLessThanMaximumTerm(DateTime firstDay, DateTime lastDay)
        {
            return (firstDay.AddDays(1) <= lastDay) && 
                   (firstDay.AddDays(maxNumberOfDaysReservation - 1) < lastDay);
        }
    }
}