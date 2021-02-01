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
}
