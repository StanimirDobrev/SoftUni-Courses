namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(0)]
        [TestCase(10)]
        [TestCase(16)]

        public void DatabaseShouldSetDataCorrectly(int elementsCount)
        {
            //Arrange
            int[] originalElements = new int[elementsCount];

            for (int i = 0; i < elementsCount; i++)
            {
                originalElements[i] = i + 1;
            }

            Database database = new Database(originalElements);

            Assert.AreEqual(elementsCount, database.Count);
            Assert.AreEqual(originalElements, database.Fetch());
        }

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(15)]

        public void DatabaseShouldAddCorrectly(int elementsCount)
        {
            int[] elements = new int[elementsCount];

            for (int i = 0; i < elementsCount; i++)
            {
                elements[i] = i + 1;
            }

            Database database = new Database(elements);

            database.Add(1);

            Assert.AreEqual(elementsCount + 1, database.Count);
        }

        [TestCase(17)]
        [TestCase(50)]
        public void DatabaseShouldNotBeCreatedIfTooMuchElementsProvided(int elementsCount)
        {
            int[] elements = new int[elementsCount];

            for (int i = 0; i < elementsCount; i++)
            {
                elements[i] = i + 1;
            }


            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => new Database(elements));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);
        }

        [Test]
        public void DatabaseShouldNotRemoveElementIfCountIsNegative()
        {
            Database database = new Database();

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => database.Remove());

            Assert.AreEqual("The collection is empty!", ex.Message);
        }

        [Test]

        public void RemoveShouldDecreaseCountByOne()
        {
            Database database = new Database(1, 2, 3);

            database.Remove();

            Assert.AreEqual(2, database.Count);
        }

        [Test]

        public void DatabaseShouldRemoveLastElement()
        {
            var database = new Database(1, 2, 3);

            database.Remove();

            var remainingElements = database.Fetch();

            Assert.AreEqual(new int[]{1,2}, remainingElements);
        }

    }
}
