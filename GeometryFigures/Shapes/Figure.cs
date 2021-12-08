using System;

namespace GeometryFigures
{
    public class Figure : IFigure
    {
        IFigure unknownShape;
        public double Area => unknownShape.Area; 

        public Figure(IFigure shape)
        {
            this.unknownShape = shape;
        }
    }
}
