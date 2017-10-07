using Newtonsoft.Json;

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
                var lastReservation = reservationsDB.LastReservationEnds(_carID);
                reservationsDB.AddReservation("Technical inspection", _carID, lastReservation.AddDays(1), lastReservation.AddDays(8));
                _rentsLastBeforeCheckingUp = 10;
            }
        }

        [JsonProperty]
        private byte _rentsLastBeforeCheckingUp;
        [JsonProperty]
        private int _carID;
    }
}
