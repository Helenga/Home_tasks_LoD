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
        public void CreateFindCarsQuery_ShouldReturnOnlyListOfAvailableCars()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");
            admin.CreateAddCarQuery(2, "Volvo", "black");
            Client client = new Client("Jonny Stroke");
            ReservationsDB reservationDB = new ReservationsDB();
            reservationDB.AddReservation("some client", 2,
                        new DateTime(2017, 12, 1), new DateTime(2017, 12, 7));
            reservationDB.AddReservation("another client", 1,
                        new DateTime(2017, 11, 7), new DateTime(2017, 12, 5));

            List<Car> result = client.CreateFindCarsQuery(new DateTime(2017, 12, 7),
                                        new DateTime(2017, 12, 13)).ToList();
            List<Car> expected = new List<Car> { admin.CreateGetAllCarsQuery().
                                                 ToList().Find(car => car.ID == 1) };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PassingDatesCoincidedWhithExistedReservationToIsFreeToRentIn_ShouldReturnFalse()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(2, "Volvo", "black");
            Client client = new Client("Jonny Stroke");
            ReservationsDB reservationDB = new ReservationsDB();
            reservationDB.AddReservation("some client", 2,
                        new DateTime(2017, 10, 8), new DateTime(2017, 11, 1));
            List<Car> result = client.CreateFindCarsQuery(new DateTime(2017, 10, 7),
                                        new DateTime(2017, 11, 3)).ToList();
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void AfterAddingTenReservations_CheckUpControl_ShouldAddExtraReservationForSevenDays()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");

            Client client1 = new Client("Client1");
            Client client2 = new Client("Client2");
            Client client3 = new Client("Client3");
            Client client4 = new Client("Client4");
            Client client5 = new Client("Client5");
            Client client6 = new Client("Client6");
            Client client7 = new Client("Client7");
            Client client8 = new Client("Client8");
            Client client9 = new Client("Client9");
            Client client10 = new Client("Client10");

            client1.CreateFindCarsQuery(new DateTime(2017, 9, 6), new DateTime(2017, 10, 7));
            client1.CreateReserveCarQuery(1);
            client2.CreateFindCarsQuery(new DateTime(2017, 10, 8), new DateTime(2017, 10, 9));
            client2.CreateReserveCarQuery(1);
            client3.CreateFindCarsQuery(new DateTime(2017, 11, 1), new DateTime(2017, 11, 5));
            client3.CreateReserveCarQuery(1);
            client4.CreateFindCarsQuery(new DateTime(2018, 3, 6), new DateTime(2018, 3, 7));
            client4.CreateReserveCarQuery(1);
            client5.CreateFindCarsQuery(new DateTime(2017, 12, 1), new DateTime(2017, 12, 7));
            client5.CreateReserveCarQuery(1);
            client6.CreateFindCarsQuery(new DateTime(2017, 12, 8), new DateTime(2017, 12, 9));
            client6.CreateReserveCarQuery(1);
            client7.CreateFindCarsQuery(new DateTime(2018, 9, 6), new DateTime(2018, 10, 7));
            client7.CreateReserveCarQuery(1);
            client8.CreateFindCarsQuery(new DateTime(2017, 11, 6), new DateTime(2017, 11, 7));
            client8.CreateReserveCarQuery(1);
            client9.CreateFindCarsQuery(new DateTime(2019, 1, 6), new DateTime(2019, 1, 7));
            client9.CreateReserveCarQuery(1);


            client10.CreateFindCarsQuery(new DateTime(2017, 12, 30), new DateTime(2018, 1, 1));
            client10.CreateReserveCarQuery(1);
            ReservationsDB reservationDB = new ReservationsDB();
            var result = reservationDB.LastReservationEnds(1);
            DateTime expected = new DateTime(2019, 1, 15);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReservationExpirationControl_ShouldDeleteAllExpiredReservations()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");

            Client client1 = new Client("Client1");
            Client client2 = new Client("Client2");

            client1.CreateFindCarsQuery(DateTime.Now.AddDays(-1), DateTime.Now);
            client1.CreateReserveCarQuery(1);
            client2.CreateFindCarsQuery(new DateTime(2017, 10, 8), new DateTime(2017, 10, 9));
            client2.CreateReserveCarQuery(1);

            ReservationsDB reservationsDB = new ReservationsDB();
            Assert.IsFalse(reservationsDB.DoesClientHaveReservation("client1"));
        }

        [TestMethod]
        [ExpectedException(typeof(DatesAreNotValid))]
        public void WhenPassingTooLongTermReservationTo_GetAllAvailableCars_ShouldThrowException()
        {
            Client client = new Client("client");
            client.CreateFindCarsQuery(new DateTime(2018, 9, 10), new DateTime(2019, 9, 9));
        }
        // проверка выброса ошибки, если клиент уже имеет резервацию
        [TestMethod]
        [ExpectedException(typeof(TheClientAlreadyHasReservation))]
        public void IfClientTriesToReserveMoreThanOneCar_ReserveChoosenCar_ShouldThrowException()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");
            admin.CreateAddCarQuery(2, "Volvo", "black");

            Client client1 = new Client("Client1");
            client1.CreateFindCarsQuery(new DateTime(2018, 9, 6), new DateTime(2018, 10, 7));
            client1.CreateReserveCarQuery(1);
            client1.CreateReserveCarQuery(2);
        }

        [TestMethod]
        [ExpectedException(typeof(CarIsUnavailable))]
        public void IfClientTriesToReserveCarWhichReservedDuringTheTerm_ReserveChoosenCar_ShouldThrowexception()
        {
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(1, "Renault", "Red");

            Client client1 = new Client("Client1");
            Client client2 = new Client("Client2");
            client1.CreateFindCarsQuery(new DateTime(2018, 9, 6), new DateTime(2018, 10, 7));
            client1.CreateReserveCarQuery(1);
            client2.CreateFindCarsQuery(new DateTime(2018, 10, 1), new DateTime(2018, 10, 5));
            client2.CreateReserveCarQuery(1);
        }


    }
}
