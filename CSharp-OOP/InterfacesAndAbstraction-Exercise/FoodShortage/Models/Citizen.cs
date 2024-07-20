using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShortage.Models.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen : IBuyer, IIdentifiable, IBirthdate
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; }
        public int Age { get; }
        public int Food { get; private set; }
        public string Id { get; }
        public string Birthdate { get; }

        public void BuyFood()
            => this.Food += 10;
    }
}
