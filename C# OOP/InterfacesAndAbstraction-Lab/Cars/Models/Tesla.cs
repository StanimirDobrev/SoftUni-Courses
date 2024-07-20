using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Models.Interfaces;

namespace Cars.Models
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string model, string color, int battery) 
            : base(model, color)
        {
            this.Battery = battery;
        }

        public int Battery { get; }

        public override string ToString()
            => $"{base.ToString()} with {Battery} Batteries";
    }
}
