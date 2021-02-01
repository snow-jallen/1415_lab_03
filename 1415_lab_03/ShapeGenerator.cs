using _1415_lab_03.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace _1415_lab_03
{
    public class ShapeGenerator
    {
        public static IEnumerable<IShape> CreateShapes()
        {
            return new IShape[] {
                new Circle(new Point(50, 50), 15)
                {
                    Fill = Brushes.Black,
                    Stroke = Brushes.Violet,
                    StrokeThickness = 10,
                },
                new Ellipse(new Point { X = 150, Y = 150}, 20, 35)
                {
                    Fill = Brushes.Red,
                    Stroke = Brushes.Honeydew,
                    StrokeThickness = 15
                },
                //Add your other shapes here
            };
        }
    }
}
