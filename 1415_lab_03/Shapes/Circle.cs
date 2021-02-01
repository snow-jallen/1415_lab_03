using System.Windows;

namespace _1415_lab_03.Shapes
{
    public class Circle : Ellipse
    {
        public Circle(Point origin, int radius)
            : base(origin, radius, radius)
        {

        }
    }
}
