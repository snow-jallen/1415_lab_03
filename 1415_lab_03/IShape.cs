using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace _1415_lab_03
{
    public interface IShape
    {
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }
        public decimal CalculateArea();
    }

    public class Square : IShape
    {
        public Square()
        {
        }

        public Square(Point origin, int sideLength)
        {
            Origin = origin;
            SideLength = sideLength;
        }

        public int SideLength { get; init; }
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }

        public decimal CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    public class Rectangle : IShape
    {
        public Rectangle()
        {
        }

        public Rectangle(Point origin, int length, int width)
        {
            Origin = origin;
            Height = length;
            Width = width;
        }

        public int Height { get; init; }
        public int Width { get; init; }
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }

        public decimal CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Ellipse : IShape
    {
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }

        public int Radius1 { get; init; }

        public int Radius2 { get; init; }

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * Radius1 * Radius2;
        }
    }

    public class Circle : Ellipse
    {
    }

    public class Triangle : IShape
    {
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }

        public int Base { get; init; }

        public int Height { get; init; }



        public decimal CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
