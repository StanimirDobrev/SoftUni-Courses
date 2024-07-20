using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayCelebrations.Models.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IBirthdate, IIdentifiable
    {
        public Citizen(string name, string age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
            Id = id;
        }

        public string Name { get; }
        public string Age { get; }
        public string Birthdate { get; }
        public string Id { get; }
    }
}
