using _1415_lab_03.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace _1415_lab_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            foreach(var s in ShapeGenerator.CreateShapes())
            {
                switch(s)
                {
                    case Square square:
                        canvas.Children.Add(square.ToRectangle());
                        break;
                    case Rectangle rectangle:
                        canvas.Children.Add(rectangle.ToRectangle());
                        break;
                    case Circle circle:
                        canvas.Children.Add(circle.ToEllipse());
                        break;
                    case Ellipse ellipse:
                        canvas.Children.Add(ellipse.ToEllipse());
                        break;
                    case Triangle triangle:
                        canvas.Children.Add(triangle.ToPolygon());
                        break;
                }

            }
        }
    }
}
