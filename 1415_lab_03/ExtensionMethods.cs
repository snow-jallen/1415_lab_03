using _1415_lab_03.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _1415_lab_03.Shapes
{
    public static class ExtensionMethods
    {
        public static System.Windows.Shapes.Rectangle ToRectangle(this Square square)
        {
            return new System.Windows.Shapes.Rectangle
            {
                Stroke = square.Stroke,
                Fill = square.Fill,
                Height = square.Height,
                Width = square.Width,
                RenderTransform = new TranslateTransform(square.Origin.X, square.Origin.Y)
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
                RenderTransform = new TranslateTransform(rect.Origin.X, rect.Origin.Y)
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
                RenderTransform = new TranslateTransform(circle.Origin.X, circle.Origin.Y)
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
                RenderTransform = new TranslateTransform(ellipse.Origin.X, ellipse.Origin.Y)
            };
        }

        public static Polygon ToPolygon(this Triangle triangle)
        {
            var points = new PointCollection();

            points.Add(new Point(triangle.Origin.X + 0.5 * triangle.Base, triangle.Origin.Y + 0.5 * triangle.Height));
            points.Add(new Point(triangle.Origin.X, triangle.Origin.Y - 0.5 * triangle.Height));
            points.Add(new Point(triangle.Origin.X - 0.5 * triangle.Base, triangle.Origin.Y + 0.5 * triangle.Height));


            return new Polygon
            {
                Stroke = triangle.Stroke,
                Fill = triangle.Fill,
                Points = points
            };
        }

    }
}
