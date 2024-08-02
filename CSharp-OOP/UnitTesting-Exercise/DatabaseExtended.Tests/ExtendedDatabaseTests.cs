using System;
using ExtendedDatabase;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace DatabaseExtended.Tests
{
    using NUnit.Framework;
    using System.Reflection.Metadata;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;
        private Person person;

        [SetUp]
        public void SetUp()
        {
            this.person = new Person(1, "TestUser");
            this.database = new Database();
        }

        [Test]

        public void ConstructorShouldBeInitializedEmpty()
        {
            Assert.AreEqual(0, database.Count);
        }

        [Test]
        public void ConstructorShouldAddPersonProperly()
        {
            Person[] people = new Person[]
            {
                new Person(1, "User1"),
                new Person(2, "User2"),
                new Person(3, "User3")
            };

            Database database = new Database(people);

            Assert.AreEqual(people.Length, database.Count);

            foreach (var person in people)
            {
                Assert.AreEqual(person, database.FindById(person.Id));
                Assert.AreEqual(person, database.FindByUsername(person.UserName));
            }
        }

        [TestCase(17)]
        [TestCase(50)]
        public void ConstructorShouldThrowIfCountIsMoreThan16People(int personCount)
        {
            Person[] people = new Person[personCount];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"User{i}");
            }

            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Database(people));

            Assert.AreEqual("Provided data length should be in range [0..16]!", ex.Message);
        }

        [Test]
        public void AddShouldThrowIfCountIsMoreThan16People()
        {
            Person[] people = new Person[16];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"User{i}");
            }

            database = new Database(people);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => database.Add(person));
            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            database.Add(person);
            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void AddShouldThrowExceptionIfUsernameExists()
        {
            database.Add(person);

            InvalidOperationException ex = 
                Assert.Throws<InvalidOperationException>(() => database.Add(new Person(2, "TestUser")));

            Assert.AreEqual("There is already user with this username!", ex.Message);
        }

        [Test]
        public void AddShouldThrowExceptionIfIdExists()
        {
            database.Add(person);

            InvalidOperationException ex =
                Assert.Throws<InvalidOperationException>(() => database.Add(new Person(1, "AnotherUser")));

            Assert.AreEqual("There is already user with this Id!", ex.Message);
        }

        [Test]
        public void RemoveShouldThrowExceptionIfCountIsNegative()
        {
            database = new Database();

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void RemoveShouldDecreaseCount()
        {
            Person[] people = new Person[]
            {
                new Person(1, "User1"),
                new Person(2, "User2")
            };
            database = new Database(people);

            database.Remove();
            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void FindByUsernameShouldReturnCorrectPerson()
        {
            database.Add(person);
            var foundPerson = database.FindByUsername("TestUser");

            Assert.AreEqual(person, foundPerson);
        }

        [Test]
        public void FindByUsernameShouldThrowExceptionWhenEmpty()
        {
            Database database = new Database();
            

            ArgumentNullException exception =
                Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));
            
        }

        [Test]
        public void FindByUsernameShouldThrowExceptionIfNameNotFound()
        {
            InvalidOperationException ex =
                Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Ivan"));
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void FindByIdShouldThrowExceptionIfGivenIdIsNegative(int givenId)
        {
            ArgumentOutOfRangeException ex = 
                Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(givenId));
        }

        [Test]
        public void FindByIdShouldThrowExceptionIfIdNotFound()
        {
            InvalidOperationException ex = 
                Assert.Throws<InvalidOperationException>(() => database.FindById(10));
        }

        [Test]
        public void FindByIdShouldReturnCorrectPerson()
        {
            database.Add(person);
            var foundPerson = database.FindById(1);
            Assert.AreEqual(person, foundPerson);

        }
    }
}