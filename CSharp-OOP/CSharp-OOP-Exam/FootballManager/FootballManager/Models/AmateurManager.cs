using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class AmateurManager : Manager
    {
        private const double initialRankingValue = 15;
        public AmateurManager(string name) 
            : base(name, initialRankingValue)
        {
        }

        public override void RankingUpdate(double updateValue)
        {
            Ranking += updateValue * 0.75;
        }
    }
}
