using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRental;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.ComponentModel.DataAnnotations;

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

        // Test ClientFunctions
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void PassingTooShortFIOToClient_ShouldRaiseValidationException()
        {
            Client client = new Client("");
        }

        [TestMethod]
        public void CreateAddCarQueryFromAdmin_ShouldAddCarToCarsDB()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");
            Car car = new Car(1, "Renault", "Red");
            Equals(admin.CreateGetAllCarsQuery().First(), car);
        }

        [TestMethod]
        public void T()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");
            admin.CreateAddCarQuery(2, "Volvo", "black");
            /*CarsDB carsDB = new CarsDB();
            carsDB.AddNewCar(1, "Renault", "Red");
            carsDB.AddNewCar(2, "Volvo", "black");*/
            Client client = new Client("Jonny Stroke");
            ReservationsDB reservationDB = new ReservationsDB();
            reservationDB.AddReservation("some client", 2, 
                        new DateTime(2017, 9, 6), new DateTime(2017, 10, 7));
            reservationDB.AddReservation("another client", 1, 
                        new DateTime (2017, 11, 7), new DateTime(2017, 12, 7));
            
            List<Car> result = client.CreateFindCarsQuery(new DateTime (2017, 10, 7),
                                        new DateTime (2017, 11, 3)).ToList();
            List<Car> expected = new List<Car> { admin.CreateGetAllCarsQuery().
                                                 ToList().Find(car => car.ID == 1) };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
