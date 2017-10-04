using System;

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

        public void ChangeStatus()
        {

        }

        public void SendToRent()
        {
            // изменить даты доступности и статус
        }

        public void ReturnBack()
        {
            // когда дата недоступности истекла изменить статус на свободна
        }

        public void SendToCheckUp()
        {
            // если 0 то убрать и изменить даты доступности и статус
        }

        public bool IsFreeToRent()
        {

            return (default(bool));
        }

        public string Model { get; }
        public string Color { get; }
        public int ID { get; } // уникальный идентификатор авто

        private OccupationStatus _occupationStatus;

        public DateTime UnavailableFrom { get; } // недоступен c
        public DateTime UnavailableTo { get; } // до
        // потом 
        private byte _rentsLastBeforeCheckingUp; // осталось аренд до помещения в техцентр
    }
}
