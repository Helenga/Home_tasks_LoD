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
            ReservationExpirationControl();
            Reservation reservation = new Reservation(clientName, carID, firstDayOfReservation, lastDayOfReservation);
            _reservedCars.Add(reservation);
        }

        public bool DoesClientHaveReservation(string clientName)
        {
            return _reservedCars.Exists(reservation => reservation.Renter == clientName);
        }

        // automatically deletes expired reservations
        private void ReservationExpirationControl()
        {
            _reservedCars.RemoveAll(reservation => reservation.UnavailableTo <= DateTime.Now);
        }

        public bool IsFreeToRentIn(int carID, DateTime from, DateTime to)
        {
            // ни одна из точек не лежит в границах существующей резервации
            return SelectReservationsForCarWithID(carID).
                       All(reservation => (reservation.UnavailableFrom > from) &&
                                            (reservation.UnavailableFrom > to) ||
                                            (reservation.UnavailableTo < from) &&
                                            (reservation.UnavailableTo < to));
        }

        private List<Reservation> SelectReservationsForCarWithID(int carID)
        {
            List<Reservation> reservationsForCarWithID = _reservedCars.FindAll(car => car.CarID == carID);
            return reservationsForCarWithID;
        }

        public DateTime LastReservationEnds(int carID)
        {
            return SelectReservationsForCarWithID(carID).
                           Max(reservation => reservation.UnavailableTo);
            
        }
    }
}
