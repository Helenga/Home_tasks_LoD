using System;
using System.Collections.Generic;

namespace CarRental
{
    class Car
    {
        public Car(int id, string model, string color)
        {
            ID = id;
            Model = model;
            Color = color;
            _occupationStatus = OccupationStatus.Free;
            _rentsLastBeforeCheckingUp = 10;
        }

        public void AddReservationDates(DateTime from, DateTime to)
        {
            ReservationsDates reservationDates = new ReservationsDates(from, to);
            this.Reservations.Add(reservationDates);
            _rentsLastBeforeCheckingUp -= 1;
        }

        public void CheckUpControl()
        {
            if (this._rentsLastBeforeCheckingUp == 0)
            {
                // найти последнюю дату проката, добавить резервацию с 1 день + последнего до 8 день +
                this.AddReservationDates(this.Reservations.Find());
            }
        }



        public void ChangeStatus()
        {

        }

        public void SendToRent()
        {
            _rentsLastBeforeCheckingUp -= 1;
        }

        public void ReturnBack()
        {
            // когда дата недоступности истекла изменить статус на свободна
        }

        public void SendToCheckUp()
        {
            // если 0 то убрать и изменить даты доступности и статус
        }

        public bool IsFreeToRentIn(DateTime from, DateTime to)
        {
            
            return (default(bool));
        }

        public string Model { get; }
        public string Color { get; }
        public int ID { get; } // уникальный идентификатор авто

        private OccupationStatus _occupationStatus;


        public List<ReservationsDates> Reservations { get; private set; }
        //public DateTime UnavailableFrom { get; } // недоступен c
        //public DateTime UnavailableTo { get; } // до
        // потом 
        private byte _rentsLastBeforeCheckingUp; // осталось аренд до помещения в техцентр
    }
}
