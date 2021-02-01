using System;
using System.Windows;

namespace _1415_lab_03.Shapes
{
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
}
