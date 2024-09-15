using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Core.Contracts;
using FootballManager.Models;
using FootballManager.Models.Contracts;
using FootballManager.Repositories;
using FootballManager.Utilities.Messages;

namespace FootballManager.Core
{
    public class Controller : IController
    {
        private readonly TeamRepository championship;

        public Controller()
        {
            championship = new TeamRepository();
        }
        public string JoinChampionship(string teamName)
        {
            var team = new Team(teamName);
            
            if (championship.Models.Count >= 10)
            {
                return OutputMessages.ChampionshipFull;
            }

            if (championship.Exists(teamName))
            {
                return string.Format(OutputMessages.TeamWithSameNameExisting, teamName);
            }

            championship.Add(team);
            return string.Format(OutputMessages.TeamSuccessfullyJoined, teamName);
        }

        public string SignManager(string teamName, string managerTypeName, string managerName)
        {
            var team = championship.Get(teamName);
            if (team is null)
            {
                return string.Format(OutputMessages.TeamDoesNotTakePart, teamName);
            }

            if (team.TeamManager is not null)
            {
                return string.Format(OutputMessages.TeamSignedWithAnotherManager, teamName, team.TeamManager.Name);
            }

            if (championship.Models.Any(t => t.TeamManager != null && t.TeamManager.Name == managerName))
            {
                return string.Format(OutputMessages.ManagerAssignedToAnotherTeam, managerName);
            }

            IManager manager;
            switch (managerTypeName)
            {
                case nameof(AmateurManager):
                    manager = new AmateurManager(managerName);
                    break;
                case nameof(SeniorManager):
                    manager = new SeniorManager(managerName);
                    break;
                case nameof(ProfessionalManager):
                    manager = new ProfessionalManager(managerName);
                    break;
                default:
                    return string.Format(OutputMessages.ManagerTypeNotPresented, managerTypeName);
            }

            team.SignWith(manager);
            return string.Format(OutputMessages.TeamSuccessfullySignedWithManager, managerName, teamName);
        }

        public string MatchBetween(string teamOneName, string teamTwoName)
        {

            var teamOne = championship.Get(teamOneName);
            var teamTwo = championship.Get(teamTwoName);

            if (teamOne is null || teamTwo is null)
            {
                return string.Format(OutputMessages.OneOfTheTeamDoesNotExist);
            }

            if (teamOne.PresentCondition > teamTwo.PresentCondition)
            {
                teamOne.GainPoints(3);
                teamOne.TeamManager?.RankingUpdate(5);
                teamTwo.TeamManager?.RankingUpdate(-5);
                return string.Format(OutputMessages.TeamWinsMatch, teamOneName, teamTwoName);
            }
            if (teamTwo.PresentCondition > teamOne.PresentCondition)
            {
                teamTwo.GainPoints(3);
                teamTwo.TeamManager?.RankingUpdate(5);
                teamOne.TeamManager?.RankingUpdate(-5);
                return string.Format(OutputMessages.TeamWinsMatch, teamTwoName, teamOneName);
            }

            teamOne.GainPoints(1);
            teamTwo.GainPoints(1);
            return string.Format(OutputMessages.MatchIsDraw, teamOneName, teamTwoName);
        }

        public string PromoteTeam(string droppingTeamName, string promotingTeamName, string managerTypeName, string managerName)
        {
            var droppingTeam = championship.Get(droppingTeamName);
            if (droppingTeam is null)
            {
                return string.Format(OutputMessages.DroppingTeamDoesNotExist, droppingTeamName);
            }

            if (championship.Exists(promotingTeamName))
            {
                return string.Format(OutputMessages.TeamWithSameNameExisting, promotingTeamName);
            }

            IManager manager = null;

            switch (managerTypeName)
            {
                case nameof(AmateurManager):
                    manager = new AmateurManager(managerName);
                    break;
                case nameof(SeniorManager):
                    manager = new SeniorManager(managerName);
                    break;
                case nameof(ProfessionalManager):
                    manager = new ProfessionalManager(managerName);
                    break;
                default:
                    return string.Format(OutputMessages.ManagerTypeNotPresented, managerTypeName);
            }

            var newTeam = new Team(promotingTeamName);
            if (manager is not null)
            {
                newTeam.SignWith(manager);
            }

            foreach (ITeam team in championship.Models)
            {
                team.ResetPoints();
            }

            championship.Remove(droppingTeamName);
            championship.Add(newTeam);
            return string.Format(OutputMessages.TeamHasBeenPromoted, promotingTeamName);
        }

        public string ChampionshipRankings()
        {
            List<ITeam> orderedTeams = championship.Models
                .OrderByDescending(t => t.ChampionshipPoints)
                .ThenByDescending(t => t.PresentCondition)
                .ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***Ranking Table***");
            for (int i = 0; i < orderedTeams.Count(); i++)
            {
                var team = orderedTeams[i];
                sb.AppendLine($"{i + 1}. {team.ToString()}/{team.TeamManager.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
