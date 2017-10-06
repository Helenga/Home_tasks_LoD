using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental
{
    class ReservationsDB
    {
        private static List<Reservation> ReservedCars; // одинаковый для любого экземпляра сервиса

        public void AddReservation(string clientName, int carID, DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            Reservation reservation = new Reservation(clientName, carID, firstDayOfReservation, lastDayOfReservation);
            ReservedCars.Add(reservation);
        }

        public bool DoesClientHaveReservation(string clientName)
        {
            return ReservedCars.Exists(reservation => reservation.Renter == clientName);
        }

        // automatically deletes expired reservations
        private void ReservationExpirationControl(Car car)
        {
            ReservedCars.RemoveAll(reservation => reservation.UnavailableTo == DateTime.Now);
        }

        public bool IsFreeToRentIn(DateTime from, DateTime to)
        {
            // ни одна из точек не лежит в границах существующей резервации
            return ReservedCars.All(reservation => (reservation.UnavailableFrom > from) &&
                                            (reservation.UnavailableTo < from) &&
                                            (reservation.UnavailableFrom > to) &&
                                            (reservation.UnavailableTo < to) &&
                                            !(
                                              (reservation.UnavailableFrom >= from) &&
                                              (reservation.UnavailableTo <= to)
                                            ));
        }

        public DateTime LastReservationEnds()
        {
            return ReservedCars.Max(reservation => reservation.UnavailableTo);
        }
    }
}
