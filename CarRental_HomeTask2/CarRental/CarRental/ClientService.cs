using System;
using System.Collections.Generic;
using Exceptions;

namespace CarRental
{
    public class ClientService : Service, IClientFunctions
    {
        public IEnumerable<Car> GetAllAvailableCars(DateTime firstDayOfReservation, 
                                                    DateTime lastDayOfReservation)
        {
            if (IsNumberOfDaysLessThanMaximumTerm(firstDayOfReservation, lastDayOfReservation))
            {
                return _carsDB.SelectCarsWhichAvailableIn(firstDayOfReservation, lastDayOfReservation);
            }
            else
            {
                throw new DatesAreNotValid();
            }
        }

        public void ReserveChoosenCar(string clientName, int carID, DateTime from, DateTime to)
        {
            if (!_reservationsDB.DoesClientHaveReservation(clientName))
            {
                if (_reservationsDB.IsFreeToRentIn(carID, from, to))
                {
                    _reservationsDB.AddReservation(clientName, carID, from, to);
                    _carsDB.RefreshCarStatus(carID);
                }
                else
                {
                    throw new CarIsUnavailable();
                }
            }
            else
            {
                throw new TheClientAlreadyHasReservation();
            }
        }

        private bool IsNumberOfDaysLessThanMaximumTerm(DateTime firstDay, DateTime lastDay)
        {
            return (firstDay.AddDays(1) >= firstDay) && 
                   (firstDay.AddDays(maxNumberOfDaysReservation - 1) >= lastDay);
        }
    }
}