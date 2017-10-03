using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car
    {
        public Car(string model, string color, OccupationStatus occupationStatus)
        {
            Model = model;
            Color = color;
            _occupationStatus = occupationStatus;
        }

        public void ChangeStatus()
        {

        }

        public void SendToRent()
        {

        }

        public void ReturnBack()
        {

        }

        public void SendToCheckUp()
        {

        }

        public bool IsFreeToRent()
        {

            return (default(bool));
        }

        public string Model { get; }
        public string Color { get; }

        private int _countOfRents;
        private OccupationStatus _occupationStatus;
    }
}
    }
}
