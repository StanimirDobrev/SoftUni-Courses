using System;
using NUnit.Framework;

namespace Championship.Tests
{
    public class Tests
    {
        private League league;
        private Team team1;
        private Team team2;
        private Team team3;
        [SetUp]
        public void Setup()
        {
            league = new League();
            team1 = new Team("Team A");
            team2 = new Team("Team B");
            team3 = new Team("Team C");
        }

        [Test]
        public void Constructor_ShouldSetDataProperlyAndCapacity_ShouldBe10()
        {
            League league = new League();
            Assert.AreEqual(10, league.Capacity);
        }
        [Test]
        public void AddTeam_ShouldWorkProperly()
        {
            League league = new League();
            Team team = new Team("Barcelona");
            league.AddTeam(team);

            Assert.AreEqual(1, league.Teams.Count);
        }

        [Test]
        public void AddTeam_ShouldThrowExceptionWhenLeagueIsFull()
        {
            League league = new League();
            Team newTeam = new Team("asd");
            for (int i = 0; i < league.Capacity; i++)
            {
                Team team = new Team($"Team {i + 1}");
                league.AddTeam(team);
            }

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => league.AddTeam(newTeam));
            Assert.AreEqual("League is full.", ex.Message);
        }

        [Test]
        public void AddTeam_ShouldThrowExceptionWhenTeamExists()
        {
            League league = new League();
            Team team = new Team("asd");
            league.AddTeam(team);
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => league.AddTeam(team));
            Assert.AreEqual("Team already exists.", ex.Message);
        }

        [Test]
        public void RemoveTeam_ShouldReturnFalseWhenIsNull()
        {
            string teamName = null;
            Team team = new Team(teamName);
            League league = new League();

            Assert.AreEqual(false, league.RemoveTeam(teamName));
        }

        [Test]
        public void RemoveTeam_ShouldWorkPropelryAndReturnTrue()
        {
            string teamName = "Barcelona";
            Team team = new Team(teamName);
            League league = new League();
            league.AddTeam(team);
            Assert.AreEqual(true, league.RemoveTeam(teamName));
            Assert.AreEqual(0, league.Teams.Count);
        }

        [Test]
        public void PlayMatch_ShouldWorkProperlyWithHomeWin()
        {
            league.AddTeam(team1);
            league.AddTeam(team2);

            league.PlayMatch(team1.Name, team2.Name, 2, 1);

            Assert.AreEqual(1, team1.Wins);
            Assert.AreEqual(1, team2.Loses);
            Assert.AreEqual(3, team1.Points);
            Assert.AreEqual(0, team2.Points);
        }

        [Test]
        public void PlayMatch_ShouldWorkProperlyWithAwayWin()
        {
            league.AddTeam(team1);
            league.AddTeam(team2);

            league.PlayMatch(team1.Name, team2.Name, 1, 2);

            Assert.AreEqual(1, team2.Wins);
            Assert.AreEqual(1, team1.Loses);
            Assert.AreEqual(3, team2.Points);
            Assert.AreEqual(0, team1.Points);
        }

        [Test]
        public void PlayMatch_ShouldWorkProperlyWhenDraw()
        {
            league.AddTeam(team1);
            league.AddTeam(team2);

            league.PlayMatch(team1.Name, team2.Name, 1, 1);

            Assert.AreEqual(1, team2.Draws);
            Assert.AreEqual(1, team1.Draws);
            Assert.AreEqual(1, team2.Points);
            Assert.AreEqual(1, team1.Points);
        }

        [Test]
        public void PlayMatch_ShouldThrowExceptionWhenOneTeamIsNull()
        {
            league.AddTeam(team1);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() 
                => league.PlayMatch(team1.Name, "asd", 1, 0));

            Assert.AreEqual("One or both teams do not exist.", ex.Message);
        }

        [Test]
        public void GetTeamInfo_ShouldThrowExceptionWhenTeamNotExists()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => league.GetTeamInfo("asd"));
            Assert.AreEqual("Team does not exist.", ex.Message);
        }

        [Test]
        public void GetTeamInfo_ShouldWorkProperly()
        {
            league.AddTeam(team1);

            Assert.AreEqual(team1.ToString(), league.GetTeamInfo(team1.Name));
        }
    }
}