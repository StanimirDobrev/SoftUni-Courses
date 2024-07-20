using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void NewAxeShouldSetDataCorrectly()
        {
            //Arrange
            Axe axe = new Axe(10, 5);


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
            Axe axe = new Axe(10, durabilityPoints);
            Dummy dummy = new Dummy(100, 100);
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
            Axe axe = new Axe(10, initialDurabilityPoints);
            Dummy dummy = new Dummy(100, 100);
            //Act
            axe.Attack(dummy);
            //Assert
            Assert.AreEqual(expectedDurabilityPoints,axe.DurabilityPoints);

        }
        
    }
}