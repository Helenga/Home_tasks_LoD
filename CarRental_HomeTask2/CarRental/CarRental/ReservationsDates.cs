using System;
using System.Collections.Generic;

namespace CarRental
{
    class ReservationsDates
    {
        public ReservationsDates(DateTime unavailableFrom, DateTime unavailableTo)
        {
            this.UnavailableFrom = unavailableFrom;
            this.UnavailableTo = unavailableTo;
        }
        public DateTime UnavailableFrom;
        public DateTime UnavailableTo;
    }
}
