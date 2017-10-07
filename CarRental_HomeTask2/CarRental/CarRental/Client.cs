using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CarRental
{
    public class Client
    {
        public Client(string fio)
        {
            FIO = fio;
            service = new ClientService();
        }

        IClientFunctions service;

        public IEnumerable<Car> CreateFindCarsQuery(DateTime firstDayOfReservation, DateTime lastDayOfReservation)
        {
            _firstDayOfReservation = firstDayOfReservation;
            _lastDayOfReservation = lastDayOfReservation;
            return service.GetAllAvailableCars(_firstDayOfReservation, _lastDayOfReservation);
        }

        public void CreateReserveCarQuery(int carID)
        {
            service.ReserveChoosenCar(this.FIO, carID, _firstDayOfReservation, _lastDayOfReservation);
        }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string FIO { get; private set; }

        //organize cash for next query
        private DateTime _firstDayOfReservation;
        private DateTime _lastDayOfReservation;
    }
}
