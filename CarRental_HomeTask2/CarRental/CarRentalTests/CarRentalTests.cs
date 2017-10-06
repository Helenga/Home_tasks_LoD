using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRental;
using System.Collections.Generic;
using System.Linq;
using Exceptions;

namespace CarRentalTests
{
    [TestClass]
    public class CarRentalTests
    {
        // Test CarsDB
        [TestMethod]
        public void WhenAddingNewCarInCarsDB_ReturnListOfCarsShouldReturnThisCar()
        {
            CarsDB carsDB = new CarsDB();
            carsDB.AddNewCar(22, "Renault", "Red");
            Car car = new Car(22, "Renault", "Red");
            Equals(carsDB.ReturnListOfCars().First(), car);
        }

        [TestMethod]
        [ExpectedException(typeof(CarIDAleradyExists))]
        public void WhenAddingCarsWithTheSameIDInDifferentCopiesOfCarsDB_ReturnListOfCarsShouldThrowException()
        {
            CarsDB carsDB1 = new CarsDB();
            CarsDB carsDB2 = new CarsDB();
            Car car = new Car(22, "Volvo", "black");
            carsDB1.AddNewCar(22, "Renault", "Red");
            carsDB2.AddNewCar(22, "Volvo", "black");
        }

        [TestMethod]
        public void T()
        {

        }
    }
}
