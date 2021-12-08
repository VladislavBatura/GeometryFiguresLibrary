using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures.Shapes
{
    public class Circle : IFigure
    {
        public int Radius { get; set; }
        public double Area => Math.PI * Math.Pow(Radius, 2);
        
        public Circle()
        {
            Radius = default;
        }

        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}
