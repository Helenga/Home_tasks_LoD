using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class CheckUpControl
    {
        public CheckUpControl(int carID)
        {
            _carID = carID;
            _rentsLastBeforeCheckingUp = 10;
        }

        public void SendToCheckUpOnTime()
        {
            _rentsLastBeforeCheckingUp -= 1;
            if (_rentsLastBeforeCheckingUp == 0)
            {
                // запросить последнюю дату проката, добавить резервацию тех. обслуживания на 7 дней
                ReservationsDB reservationsDB = new ReservationsDB();
                var lastReservation = reservationsDB.LastReservationEnds();
                reservationsDB.AddReservation("Technical inspection", _carID, lastReservation.AddDays(1), lastReservation.AddDays(8));
                _rentsLastBeforeCheckingUp = 10;
            }
        }

        private byte _rentsLastBeforeCheckingUp;
        private int _carID;
    }
}
