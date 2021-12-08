using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures.Shapes
{
    public class Triangle : IFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double Area
        {
            get
            {
                var p = (A + B + C ) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public Triangle()
        {
            A = B = C = default;
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRightTriangle()
        {
            return (A == (int)Math.Round(Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)))
                || B == (int)Math.Round(Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2)))
                || C == (int)Math.Round(Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A, 2))));
        }
    }
}
