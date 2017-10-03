using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car
    {
        public Car(int id, string model, string color, OccupationStatus occupationStatus)
        {
            ID = id;
            Model = model;
            Color = color;
            _occupationStatus = occupationStatus;
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

        private DateTime _unavailableFrom; // недоступен c
        private DateTime _unavailableTo; // до
        // потом 
        private byte _rentsLastBeforeCheckingUp; // осталось аренд до помещения в техцентр
    }
}
