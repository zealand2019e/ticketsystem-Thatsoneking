using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace TESTS
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCarPrice()
        {
            Car car = new Car("BA964");
            double ExpectedCarPrice = (240);

            Assert.AreEqual(car.Price, ExpectedCarPrice,"Error");
        }
        [TestMethod]
        public void TestCarVehicleType()
        {

            Car car = new Car("BA964");
            string ExpectedVehicleType = "Car";

            Assert.AreEqual(car.VehicleType,ExpectedVehicleType, "Vehicle type is not correct");

        }
        [TestMethod]
        public void TestCarBrobizzCard()
        {
            // Arrange
            double expectedResult = 240 * 0.95;

            // Act
            Car car = new Car("BA964", true);

            // Assert
            Assert.AreEqual(expectedResult, car.Price);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "License plate is longer than 7 characters")]
        public void CarMoreThan7()
        {
            // Arrange + Act
            Car car = new Car("BA46S467875");

            // Assert
            Assert.Fail();

        }
        [TestMethod]
        public void TestMCPrice()
        {
            MC mc = new MC("BA964");
            double ExpectedCarPrice = (125);

            Assert.AreEqual(mc.Price, ExpectedCarPrice, "The Price does not match.");
        }
        [TestMethod]
        public void TestMCVehicleType()
        {
            MC mc = new MC("BA964");
            string ExpectedVehicleType = "Motorcycle";

            Assert.AreEqual(mc.VehicleType,ExpectedVehicleType, "Vehicle type is not correct");
        }
        [TestMethod]
        public void TestMCBrobizzCard()
        {
            // Arrange
            double expectedResult = 125 * 0.95;

            // Act
            MC mc = new MC("BA964", true);

            // Assert
            Assert.AreEqual(expectedResult, mc.Price);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "License plate is longer than 7 characters")]
        public void MCMoreThan7()
        {
            // Arrange + Act
            MC mc = new MC("BL465125");

            // Assert
            Assert.Fail();

        }

    }
}


