using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Models.Contracts;
using FootballManager.Repositories.Contracts;

namespace FootballManager.Repositories
{
    public class TeamRepository : IRepository<ITeam>
    {
        private readonly List<ITeam> _models;

        public TeamRepository()
        {
            _models = new List<ITeam>();
        }

        public IReadOnlyCollection<ITeam> Models => _models.AsReadOnly();
        public int Capacity { get; }
        public void Add(ITeam model)
        {
            if (!_models.Any(m => m.Name == model.Name) && _models.Count < 10) 
            {
                _models.Add(model);
            }
        }

        public bool Remove(string name)
        {
            var team = Get(name);
            if (team == null)
            {
                return false;
            }
            return _models.Remove(team);
        }

        public bool Exists(string name)
        {
            return _models.Any(m => m.Name == name);
        }

        public ITeam Get(string name)
        {
            return _models.FirstOrDefault(m => m.Name == name);
        }
    }
}
