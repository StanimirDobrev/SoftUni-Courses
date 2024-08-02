using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int InitialHealthPoints = 5;
        private const int InitialExpiriencePoints = 2;

        private Dummy dummy;

        [SetUp]

        public void SetUp()
        {
            dummy = new Dummy(InitialHealthPoints, InitialExpiriencePoints);
        }

        [Test]
        public void NewDummyShouldSetDataCorrectly()
        {
            //Act & Assert

            Assert.AreEqual(InitialHealthPoints, dummy.Health);
        }

        [Test]
        public void TakeAttackShouldDecreaseHealth()
        {
            //Arrange
            int initialAttackPoints = 3;
            int expectedAttackPoints = InitialHealthPoints - initialAttackPoints;
            //Act
            dummy.TakeAttack(initialAttackPoints);
            //Assert
            Assert.AreEqual(expectedAttackPoints, dummy.Health);
        }

        [TestCase(5)]
        [TestCase(6)]
        [TestCase(50)]
        public void TakeAttackDummyShouldThrowError(int attackPoints)
        {
            //Arrange

            //Act
            dummy.TakeAttack(attackPoints);
            //Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));

            Assert.AreEqual("Dummy is dead.", ex.Message);
        }

        [TestCase(5)]
        [TestCase(6)]
        [TestCase(50)]

        public void GiveExpirienceDeadDummyShouldReturnCorrectValue(int attackPoints)
        {
            //Act
            dummy.TakeAttack(attackPoints);

            //Assert
            Assert.AreEqual(InitialExpiriencePoints, dummy.GiveExperience());

        }

        [Test]

        public void GiveExpirienceWnenNotDeadShouldThrowError()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

            Assert.AreEqual("Target is not dead.", ex.Message);
        }

        [TestCase(0, true)]
        [TestCase(-1, true)]
        [TestCase(-20, true)]
        [TestCase(1, false)]
        [TestCase(20, false)]

        public void DeadDummyShouldReturnCorrectValue(int healthPoints, bool expectedIsDead)
        {
            dummy = new Dummy(healthPoints, InitialExpiriencePoints);
            
            Assert.AreEqual(expectedIsDead, dummy.IsDead());
        }
    }
}