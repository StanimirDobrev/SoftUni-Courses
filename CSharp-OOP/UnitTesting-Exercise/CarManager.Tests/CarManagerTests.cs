namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;
        [SetUp] 
        public void SetUp()
        {
            Car car = new Car("VW", "Golf", 10, 50);
        }
        [Test]
        public void ConstructorShouldAddDataProperly()
        {
            car = new Car("VW", "Golf", 10, 50);
            Assert.AreEqual("VW", car.Make );
            Assert.AreEqual("Golf", car.Model );
            Assert.AreEqual(10, car.FuelConsumption );
            Assert.AreEqual(50, car.FuelCapacity );
        }

        [Test]
        public void MakeCannotBeNull()
        {
            string invalidMake = null;

            var ex = Assert.Throws<ArgumentException>(() => new Car(invalidMake, "Golf", 10, 50));
            Assert.AreEqual("Make cannot be null or empty!", ex.Message);
        }

        [Test]
        public void MakeCannotBeEmptyString()
        {
            string invalidMake = "";

            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car(invalidMake, "Golf", 10, 50));
            Assert.AreEqual("Make cannot be null or empty!", ex.Message);
        }

        [Test]
        public void ModelCannotBeNull()
        {
            string invalidModel = null;

            var ex = Assert.Throws<ArgumentException>(() => new Car("VW", invalidModel, 10, 50));
            Assert.AreEqual("Model cannot be null or empty!", ex.Message);
        }

        [Test]
        public void ModelCannotBeEmpty()
        {
            string invalidModel = "";

            var ex = Assert.Throws<ArgumentException>(() => new Car("VW", invalidModel, 10, 50));
            Assert.AreEqual("Model cannot be null or empty!", ex.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void FuelConsuptionShouldNotBeNegative(double invalidConsumption)
        {
            ArgumentException ex =
                Assert.Throws<ArgumentException>(() => new Car("VW", "Golf", invalidConsumption, 50));
            Assert.AreEqual("Fuel consumption cannot be zero or negative!",ex.Message);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void FuelAmountShouldNotBeNegative(double negativeFuelAmount)
        {
            // Arrange
            var carType = typeof(Car);
            var car = (Car)Activator.CreateInstance(carType, true); // Create instance using private constructor

            // Act & Assert
            var propertyInfo = carType.GetProperty("FuelAmount");

            var ex = Assert.Throws<TargetInvocationException>(() => propertyInfo.SetValue(car, -1));
            Assert.That(ex.InnerException, Is.TypeOf<ArgumentException>());
            Assert.That(ex.InnerException.Message, Is.EqualTo("Fuel amount cannot be negative!"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void FuelCapacityShouldNotBeNegative(double negativeCapacity)
        {
            ArgumentException ex = 
                Assert.Throws<ArgumentException>(() => new Car("VW", "Golf", 10, negativeCapacity));
            Assert.AreEqual("Fuel capacity cannot be zero or negative!", ex.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void RefuelValueShouldNotBeZeroOrNegative(double negativeFuelToRefuel)
        {
            ArgumentException ex = 
                Assert.Throws<ArgumentException>(() => car.Refuel(negativeFuelToRefuel));
            Assert.AreEqual("Fuel amount cannot be zero or negative!", ex.Message);
        }

        [Test]
        public void RefuelShouldSetDataProperly()
        {
            car.Refuel(20);

            Assert.AreEqual(20,car.FuelAmount);
        }

        [Test]
        public void MaxAmountShouldBeCapacity()
        {
            Car car = new Car("VW", "Golf", 10, 50);
            car.Refuel(50);

            Assert.AreEqual(car.FuelAmount, car.FuelAmount);
        }
    }
}