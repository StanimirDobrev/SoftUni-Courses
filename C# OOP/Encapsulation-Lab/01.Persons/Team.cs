using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        private string _name;
        private List<Person> _firstTeam;
        private List<Person> _reserveTeam;

        public Team(string name)
        {
            this._name = name;
            this._firstTeam = new List<Person>();
            this._reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam => this._firstTeam.AsReadOnly();
        public IReadOnlyCollection<Person> ReserveTeam => this._reserveTeam.AsReadOnly();

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                _firstTeam.Add(person);
            }
            else
            {
                _reserveTeam.Add(person);
            }
        }

        public override string ToString() => 
            $"First team has {FirstTeam.Count} players.{Environment.NewLine}Reserve team has {ReserveTeam.Count} players.";
    }
}
