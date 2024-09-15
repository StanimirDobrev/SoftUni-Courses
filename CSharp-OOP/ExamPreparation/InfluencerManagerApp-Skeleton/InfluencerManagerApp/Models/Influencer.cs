using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Utilities.Messages;

namespace InfluencerManagerApp.Models
{
    public abstract class Influencer : IInfluencer
    {
        private readonly List<string> participations;

        private string username;
        private int followers;
        private double engagementRate;
        protected Influencer(string username, int followers, double engagementRate)
        {

            Username = username;
            Followers = followers;
            EngagementRate = engagementRate;

            participations = new List<string>();
        }

        public string Username
        {
            get => username;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.UsernameIsRequired);
                }

                username = value;
            }
        }

        public int Followers
        {
            get => followers;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.FollowersCountNegative);
                }

                followers = value;
            }
        }
        public double EngagementRate { get;}
        public double Income { get; private set; }
        public IReadOnlyCollection<string> Participations => participations.AsReadOnly();
        public void EarnFee(double amount)
        {
            Income += amount;
        }

        public void EnrollCampaign(string brand)
        {
            participations.Add(brand);
        }

        public void EndParticipation(string brand)
        {
            participations.Remove(brand);
        }

        public virtual int CalculateCampaignPrice()
        {
            return (int)(Followers * EngagementRate);
        }

        public override string ToString()
            => $"{Username} - Followers: {Followers}, Total Income: {Income}";
    }
}
