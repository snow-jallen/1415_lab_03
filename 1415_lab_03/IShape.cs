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
}
