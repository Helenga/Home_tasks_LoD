using System;
using System.Collections.Generic;

namespace CarRental
{
    abstract class ReservationsDB
    {
        public Dictionary<Client, Car> ReservedCars { get; private set; }

        public void AddReservation(Client client, Car car)
        {
            ReservedCars.Add(client, car);
        }

        public bool DoesClientHaveReservation(Client client)
        {
            return ReservedCars.ContainsKey(client);
        }

        public void DeleteReservation(Client client)
        {

        }
    }
}
