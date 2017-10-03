﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    interface IAdministratorFunctions
    {
        IEnumerable<Car> GetAllCars();

        void AddCar(Car car);
    }
}
