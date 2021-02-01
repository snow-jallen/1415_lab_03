using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace _1415_lab_03
{
    public static class ExtensionMethods
    {
        public static System.Windows.Shapes.Rectangle ToRectangle(this Square square)
        {
            return new System.Windows.Shapes.Rectangle
            {
                Stroke = square.Stroke,
                Fill = square.Fill,
                Height = square.SideLength,
                Width = square.SideLength,
                RenderTransform = square.Origin
            };
        }

        public static System.Windows.Shapes.Rectangle ToRectangle(this Rectangle rect)
        {
            return new System.Windows.Shapes.Rectangle
            {
                Stroke = rect.Stroke,
                Fill = rect.Fill,
                Height = rect.Height,
                Width = rect.Width,
                RenderTransform = rect.Origin
            };
        }

        public static System.Windows.Shapes.Ellipse ToEllipse(this Circle circle)
        {
            return new System.Windows.Shapes.Ellipse
            {
                Stroke = circle.Stroke,
                Fill = circle.Fill,
                Width = circle.Radius1,
                Height = circle.Radius2,
                RenderTransform = circle.Origin
            };
        }

        public static System.Windows.Shapes.Ellipse ToEllipse(this Ellipse ellipse)
        {
            return new System.Windows.Shapes.Ellipse
            {
                Stroke = ellipse.Stroke,
                Fill = ellipse.Fill,
                Width = ellipse.Radius1,
                Height = ellipse.Radius2,
                RenderTransform = ellipse.Origin
            };
        }


    }
}
