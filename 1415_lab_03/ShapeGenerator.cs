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
                new Circle
                {
                    Origin = new Point(50, 50),
                    Fill = Brushes.Black,
                    Stroke = Brushes.Violet,
                    StrokeThickness = 10,
                    Radius1 = 15,
                    Radius2 = 15,
                },
                new Square
                {
                    Origin = new Point{ X = 100, Y = 100},
                    Fill = Brushes.Blue,
                    Stroke = Brushes.DarkSalmon,
                    StrokeThickness = 15,
                    SideLength = 20
                },
                new Ellipse
                {
                    Origin = new Point { X = 150, Y = 150},
                    Fill = Brushes.Red,
                    Stroke = Brushes.Honeydew,
                    StrokeThickness = 15,
                    Radius1 = 20,
                    Radius2 = 35
                },
                new Rectangle
                {
                    Origin = new Point {X = 200, Y = 200},
                    Fill = Brushes.LightCyan,
                    Stroke = Brushes.Indigo,
                    StrokeThickness = 20,
                    Width = 25,
                    Height = 35,
                },
                new Triangle
                {
                    Origin = new Point {X = 350, Y = 350},
                    Fill = Brushes.DarkSlateBlue,
                    Stroke = Brushes.HotPink,
                    Base = 20,
                    Height = 15
                }
            };
        }
    }
}
