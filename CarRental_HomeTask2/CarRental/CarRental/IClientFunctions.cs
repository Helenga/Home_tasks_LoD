﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    interface IClientFunctions
    {
        IEnumerable<Car> GetAllAvailableCars(DateTime dateOfReservation);
        void ReserveThisCar(Car car);
    }
}
