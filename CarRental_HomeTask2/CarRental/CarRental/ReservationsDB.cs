using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental
{
    public class ReservationsDB
    {
        private static List<Reservation> _reservedCars; // одинаковый для любого экземпляра сервиса

        static ReservationsDB()
        {
            _reservedCars = new List<Reservation>();
        }

        public void AddReservation(string clientName, int carID, DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            Reservation reservation = new Reservation(clientName, carID, firstDayOfReservation, lastDayOfReservation);
            _reservedCars.Add(reservation); 
        }

        public bool DoesClientHaveReservation(string clientName)
        {
            return _reservedCars.Exists(reservation => reservation.Renter == clientName);
        }

        // automatically deletes expired reservations
        private void ReservationExpirationControl(Car car)
        {
            _reservedCars.RemoveAll(reservation => reservation.UnavailableTo == DateTime.Now);
        }

        public bool IsFreeToRentIn(DateTime from, DateTime to)
        {
            // ни одна из точек не лежит в границах существующей резервации
            return _reservedCars.All(reservation => (reservation.UnavailableFrom > from) &&
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
            return _reservedCars.Max(reservation => reservation.UnavailableTo);
        }
    }
}
