using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace _1415_lab_03.Shapes
{
    public interface IShape
    {
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }
        public decimal CalculateArea();
    }

    public abstract class Shape : IShape
    {
        public Shape(Point origin)
        {
            Origin = origin;
        }

        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }
        public abstract decimal CalculateArea();
    }

    public class Square : Rectangle
    {
        public Square(Point origin, int sideLength)
            : base(origin, sideLength, sideLength)
        {
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(Point origin, int length, int width)
            : base(origin)
        {
            Height = length;
            Width = width;
        }

        public int Height { get; init; }
        public int Width { get; init; }

        public override decimal CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Ellipse : Shape
    {
        public Ellipse(Point origin, int radius1, int radius2)
            : base(origin)
        {
            Radius1 = radius1;
            Radius2 = radius2;
        }

        public int Radius1 { get; init; }
        public int Radius2 { get; init; }

        public override decimal CalculateArea()
        {
            return (decimal)(Math.PI * Radius1 * Radius2);
        }
    }

    public class Circle : Ellipse
    {
        public Circle(Point origin, int radius)
            : base(origin, radius, radius)
        {

        }
    }

    public class Triangle : Shape
    {
        public Triangle(Point origin, int baseLength, int heightLength)
            : base(origin)
        {
            Base = baseLength;
            Height = heightLength;
        }

        public int Base { get; init; }
        public int Height { get; init; }

        public override decimal CalculateArea()
        {
            return .5M * Base * Height;
        }
    }
}
