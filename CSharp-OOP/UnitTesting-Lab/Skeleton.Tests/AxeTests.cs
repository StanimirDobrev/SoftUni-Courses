using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int InitialAttackPoints = 10;
        private const int InitialDurabillityPoints = 5;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            axe = new(InitialAttackPoints, InitialDurabillityPoints);
            dummy = new Dummy(100, 100);
        }


        [Test]
        public void NewAxeShouldSetDataCorrectly()
        {
            //Arrange


            //Act
            int actualAttackPoints = axe.AttackPoints;
            int actualDurabilityPoints = axe.DurabilityPoints;

            //Assert
            Assert.AreEqual(10,actualAttackPoints);
            Assert.AreEqual(5, actualDurabilityPoints);
        }
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void AttackDurabilityPointsNegativeShouldThrowInvalidOperationException(int durabilityPoints)
        {
            //Arrange
            axe = new Axe(InitialAttackPoints, durabilityPoints);
            
            //Act
            InvalidOperationException ex = Assert.Throws<InvalidOperationException> (() => axe.Attack(dummy));
            //Assert

            Assert.AreEqual("Axe is broken.", ex.Message);
        }

        [TestCase(1,0)]
        [TestCase(10,9)]
        public void TestIfWeaponLosesDurabilityAfterEachAttack(int initialDurabilityPoints, int expectedDurabilityPoints)
        {
            //Arrange
            axe = new Axe(InitialAttackPoints, initialDurabilityPoints);
            
            //Act
            axe.Attack(dummy);
            //Assert
            Assert.AreEqual(expectedDurabilityPoints,axe.DurabilityPoints);

        }
        
    }
}