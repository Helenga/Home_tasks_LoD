using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSONSerializer;
using CarRental;
using System.IO;

namespace CarRentalTests
{
    [TestClass]
    public class JsonSerializerTests
    {
        [TestMethod]
        public void WhenPassingPathAndAdministratorObject_SaveToFile_ShouldCreateFile()
        {
            string path = @"C:\Users\user\Desktop\savedAdministrator.json";
            Serializer serializer = new Serializer(path);
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(5, "Volvo", "grey");
            serializer.SaveToFile(admin);
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void WhenPassingPathAndClientObject_SaveToFile_ShouldCreateFile()
        {
            string path = @"C:\Users\user\Desktop\savedClient.json";
            Serializer serializer = new Serializer(path);
            Administrator admin = new Administrator();
            admin.CreateAddCarQuery(5, "Volvo", "grey");

            Client client = new Client("Jhon Stroke");
            client.CreateFindCarsQuery(new DateTime(2018, 6, 6),
                                       new DateTime(2018, 6, 15));
            client.CreateReserveCarQuery(5);
            serializer.SaveToFile(client);
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void PassingPath_ReadFromFile_ShouldReturnObject()
        {
            string path = @"C:\Users\user\Desktop\savedAdministrator.json";
            Serializer serializer = new Serializer(path);
            Administrator admin = new Administrator();
            Object loadedAdmin = serializer.ReadFromFile();
            Assert.IsNotNull(loadedAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void PassingWrongPath_ReadFromFile_ShouldThrowException()
        {
            string path = @"C:\Users\user\savedAdministrator.json";
            Serializer serializer = new Serializer(path);
            Administrator admin = new Administrator();
            Object loadedAdmin = serializer.ReadFromFile();
        }
    }
}
