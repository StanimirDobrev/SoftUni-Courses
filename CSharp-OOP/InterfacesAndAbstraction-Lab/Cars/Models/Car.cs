using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Models.Interfaces;

namespace Cars.Models
{
    public abstract class Car : ICar

    {
        protected Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; }
        public string Color { get; }

        public string Start()
            => "Engine start";

        public string Stop()
            => "Breaaak!";

        public override string ToString() 
            => $"{Color} {Model}";
    }
}
