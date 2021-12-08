using System;
using Xunit;
using GeometryFigures;

namespace GeometryFiguresTests
{
    public class UnitTest1
    {
        [Fact]
        public void CircleWithoutValue()
        {
            //Arrange
            GeometryFigures.Shapes.Circle circle = new GeometryFigures.Shapes.Circle();

            //Act
            var area = circle.Area;

            //Assert
            Assert.Equal(0, area);
        }

        [Fact]
        public void CircleWithValue()
        {
            //Arrange
            GeometryFigures.Shapes.Circle circle = new GeometryFigures.Shapes.Circle(10);
            var trueArea = Math.PI * Math.Pow(10, 2);

            //Act
            var area = circle.Area;

            //Assert
            Assert.Equal(trueArea, area);
        }

        [Fact]
        public void TriangleWithoutValues()
        {
            //Arrange
            GeometryFigures.Shapes.Triangle triangle = new GeometryFigures.Shapes.Triangle();

            //Act
            var area = triangle.Area;

            //Assert
            Assert.Equal(0, area);
        }

        [Fact]
        public void TriangleWithValues()
        {
            //Arrange
            GeometryFigures.Shapes.Triangle triangle = new GeometryFigures.Shapes.Triangle(5, 7, 10);
            var p = (5 + 7 + 10) / 2;
            var correctArea = Math.Sqrt(p * (p - 5) * (p - 7) * (p - 10));

            //Act
            var area = triangle.Area;

            //Assert
            Assert.Equal(correctArea, area);
        }

        [Fact]
        public void TriangleIsRight()
        {
            //Arrange
            GeometryFigures.Shapes.Triangle triangle = new GeometryFigures.Shapes.Triangle(5, 5, 7);

            //Act
            bool isRight = triangle.IsRightTriangle();

            //Assert
            Assert.True(isRight);
        }

        [Fact]
        public void TriangleIsNotRight()
        {
            //Arrange
            GeometryFigures.Shapes.Triangle triangle = new GeometryFigures.Shapes.Triangle(5, 6, 7);

            //Act
            bool isRight = triangle.IsRightTriangle();

            //Assert
            Assert.False(isRight);
        }

        [Fact]
        public void AreaOfUnknownShape()
        {
            //Arrange
            GeometryFigures.Figure figure = new GeometryFigures.Figure(new GeometryFigures.Shapes.Triangle());


            //Act
            var area = figure.Area;

            //Assert
            Assert.Equal(0, area);
        }
    }
}
