using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    abstract class ReservationsDB
    {
        private Dictionary<Client, Car> _reservedCars;

        public void AddReservation(Client client, Car car)
        {

        }

        public bool DoesClientHaveReservation(Client client)
        {

        }

        public void DeleteReservation(Client client)
        {

        }
    }
}
