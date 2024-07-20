using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Models.Interfaces;

namespace Cars.Models
{
    public class Seat : Car
    {
        public Seat(string model, string color) : base(model, color)
        {
        }
    }


}
