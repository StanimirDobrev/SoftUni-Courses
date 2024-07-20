using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cars.Models.Interfaces
{
    public interface ICar
    {
        public string Model { get; }
        public string Color { get; }

        public string Start();
        public string Stop();

    }
}
