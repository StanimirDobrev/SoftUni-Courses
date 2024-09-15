using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Utilities.Messages;

namespace InfluencerManagerApp.Models
{
    public abstract class Campaign : ICampaign
    {
        private readonly List<string> contributors;
        private string brand;
        protected Campaign(string brand, double budget)
        {
            Brand = brand;
            Budget = budget;

            contributors = new List<string>();
        }

        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.BrandIsrequired);
                }

                brand = value;
            }
        }
        public double Budget { get; private set; }
        public IReadOnlyCollection<string> Contributors => contributors.AsReadOnly();
        public void Gain(double amount)
        {
            Budget += amount;
        }

        public void Engage(IInfluencer influencer)
        {
            contributors.Add(influencer.Username);
            Budget -= influencer.CalculateCampaignPrice();
        }

        public override string ToString()
            => $"{GetType().Name} - Brand: {Brand}, Budget: {Budget}, Contributors: {Contributors.Count}";
    }
}
