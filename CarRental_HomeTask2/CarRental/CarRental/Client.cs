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

        public void CreateReserveCarQuery(Car car)
        {
            service.ReserveChoosenCar(this.FIO, car.ID, _firstDayOfReservation, _lastDayOfReservation);
        }

        [Required]
        public string FIO { get; private set; }

        //organize cash for next query
        private DateTime _firstDayOfReservation;
        private DateTime _lastDayOfReservation;
    }
}
