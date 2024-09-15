using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class ProfessionalManager : Manager
    {
        private const double initialRankingValue = 60;
        public ProfessionalManager(string name) 
            : base(name, initialRankingValue)
        {
        }

        public override void RankingUpdate(double updateValue)
        {
            Ranking += updateValue * 1.5;
        }
    }
}
