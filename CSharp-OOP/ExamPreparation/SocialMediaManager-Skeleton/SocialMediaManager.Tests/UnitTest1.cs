using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaManager.Tests
{
    public class Tests
    {
        private InfluencerRepository influencerRepository;
        [SetUp]
        public void Setup()
        {
            influencerRepository = new InfluencerRepository();
        }

        [Test]
        public void NewInfluencerRepository_ShouldInitializeInfluencersCorrectly()
        {
            Assert.NotNull(influencerRepository.Influencers);
            Assert.AreEqual(0, influencerRepository.Influencers.Count);
        }

        [Test]
        public void RegisterInfluencer_ShouldThrowExceptionWhenNull()
        {
            Assert.Throws<ArgumentNullException>(() => influencerRepository.RegisterInfluencer(null));
        }

        [Test]
        public void RegisterInfluencer_ShouldThrowExceptionIfInfluencerExists()
        {
            Influencer influencer = new Influencer("Ivan", 20);

            influencerRepository.RegisterInfluencer(influencer);

            Assert.Throws<InvalidOperationException>(() => influencerRepository.RegisterInfluencer(influencer));
        }

        [Test]
        public void RegisterInfluencer_ShouldAddDataProperly()
        {
            Influencer influencer = new Influencer("Ivan", 100);

            string message = influencerRepository.RegisterInfluencer(influencer);

            Assert.AreEqual($"Successfully added influencer {influencer.Username} with {influencer.Followers}", message);
        }

        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("  ")]
        public void RemoveInfluencer_ShouldThrowExceptionWhenNullOrWhiteSpace(string name)
        {
            Assert.Throws<ArgumentNullException>(() => influencerRepository.RemoveInfluencer(name));
        }

        [Test]
        public void RemoveInfluencerShouldWorkProperly()
        {
            Influencer influencer = new Influencer("Gosho", 100);
            influencerRepository.RegisterInfluencer(influencer);

            bool removed = influencerRepository.RemoveInfluencer(influencer.Username);
            Assert.IsTrue(removed);
        }

        [Test]
        public void GetInfluencerWithMostFollowers_ShouldWorkProperly()
        {
            Influencer stancho = new Influencer("Stancho", 1000);
            Influencer petar = new Influencer("Petar", 100);
            Influencer dobcho = new Influencer("Dobcho", 10);

            influencerRepository.RegisterInfluencer(stancho);
            influencerRepository.RegisterInfluencer(petar);
            influencerRepository.RegisterInfluencer(dobcho);

            Influencer tarikat = influencerRepository.GetInfluencerWithMostFollowers();

            Assert.AreEqual(stancho.Username, tarikat.Username);
            Assert.AreEqual(stancho.Followers, tarikat.Followers);
        }

        [Test]
        public void GetInfluencerShouldWorkProperly()
        {
            Influencer expected = new Influencer("Kotora", 200);
            influencerRepository.RegisterInfluencer(expected);

            Influencer actual = influencerRepository.GetInfluencer(expected.Username);

            Assert.AreEqual(expected.Username, actual.Username);
            Assert.AreEqual(expected.Followers, actual.Followers);
        }
    }
}