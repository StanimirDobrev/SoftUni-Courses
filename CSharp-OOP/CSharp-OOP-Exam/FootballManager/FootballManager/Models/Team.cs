﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;

namespace FootballManager.Models
{
    public class Team : ITeam
    {
        private string name;

        public Team(string name)
        {
            Name = name;
            ChampionshipPoints = 0;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }
                name = value;
            }
        }
        public int ChampionshipPoints { get; private set; }
        public IManager TeamManager { get; private set; }

        public int PresentCondition
        {
            get
            {
                if (TeamManager is null)
                {
                    return 0;
                }

                if (ChampionshipPoints == 0)
                {
                    return (int)Math.Floor(TeamManager.Ranking);
                }

                return (int)Math.Floor(ChampionshipPoints * TeamManager.Ranking);
            }
        }
        public void SignWith(IManager manager)
        {
            TeamManager = manager;
        }

        public void GainPoints(int points)
        {
            ChampionshipPoints += points;
        }

        public void ResetPoints()
        {
            ChampionshipPoints = 0;
        }

        public override string ToString()
        {
            return $"Team: {Name} Points: {ChampionshipPoints}";
        }
    }
}
