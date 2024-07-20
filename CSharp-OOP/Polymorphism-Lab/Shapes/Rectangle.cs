using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; }
        public double Width { get; }
        public override double CalculatePerimeter()
            => 2 *(Height + Width);

        public override double CalculateArea()
            => Height * Width;

        public override string Draw()
            => $"Drawing {this.GetType().Name}";
    }
}
