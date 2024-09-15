using NUnit.Framework.Internal;

namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        private RailwayStation station;
        [SetUp]
        public void Setup()
        {
            station = new RailwayStation("Sliven");
        }

        [Test]
        public void Constructor_ShouldSetDataProperly()
        {
            
            Assert.AreEqual("Sliven", station.Name);
            
        }

        [TestCase(null)]
        [TestCase(" ")]
        public void NamePropery_ShouldThrowExceptionIfNameIsNullOrWhitespace(string input)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => station = new RailwayStation(input));
            Assert.AreEqual("Name cannot be null or empty!", ex.Message);
        }

        [Test]
        public void NewArrivalOnBoard_ShouldAddTrainsInfoProperly()
        {
            string expextedTrainInfo = "BDZ";
            station.NewArrivalOnBoard(expextedTrainInfo);

            Assert.AreEqual(expextedTrainInfo, station.ArrivalTrains.Dequeue());
        }

        [Test]
        public void TrainHasArrived_ShouldReturnMessageIfInfoIsDifferent()
        {
            string expextedTrainInfo = "Strela";
            station.ArrivalTrains.Enqueue("BDZ");
            
            Assert.AreEqual($"There are other trains to arrive before {expextedTrainInfo}.", station.TrainHasArrived(expextedTrainInfo));
        }

        [Test]
        public void TrainHasArrived_ShouldWorkProperly()
        {
            string expectedTrainInfo = "BDZ";
            string expectedMessage = $"{expectedTrainInfo} is on the platform and will leave in 5 minutes.";

            station.ArrivalTrains.Enqueue("BDZ");
            
            Assert.AreEqual(expectedMessage, station.TrainHasArrived(expectedTrainInfo));
            Assert.AreEqual(expectedTrainInfo, station.DepartureTrains.Dequeue());
        }

        [Test]
        public void TrainHasLeft_ShouldReturnTrue()
        {
            string expectedTrain = "Strela";
            station = new RailwayStation("Nadejda");
            station.DepartureTrains.Enqueue(expectedTrain);

            Assert.AreEqual(true, station.TrainHasLeft(expectedTrain));
        }

        [Test]
        public void TrainHasLeftShouldReturnFalse()
        {
            string expectedTrain = "Strela";
            station = new RailwayStation("Nadejda");
            station.DepartureTrains.Enqueue(expectedTrain);

            Assert.AreEqual(false, station.TrainHasLeft("Ivan"));
        }

        [Test]
        public void ArriveTrainsShouldWorkProperly()
        {
            string expectedTrain = "BDZ";
            station.ArrivalTrains.Enqueue(expectedTrain);

            Assert.AreEqual(expectedTrain, station.ArrivalTrains.Dequeue());
        }

        [Test]
        public void DepartureTrainsShouldWorkProperly()
        {
            string expectedTrain = "BDZ";
            station.DepartureTrains.Enqueue(expectedTrain);

            Assert.AreEqual(expectedTrain, station.DepartureTrains.Dequeue());
        }
    }
}