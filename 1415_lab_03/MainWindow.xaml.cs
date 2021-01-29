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
using System.Windows.Shapes;

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
            var squares = new[]
            {
                new Square(new Point(50,-50), 100){Stroke = Brushes.Black, Fill = Brushes.AliceBlue },
                new Square(new Point(250,250), 70){Stroke = Brushes.Yellow, Fill=Brushes.BlueViolet },
            };

            foreach(var s in squares)
            {
                canvas.Children.Add(new Rectangle
                {
                    Stroke = s.Stroke,
                    Fill = s.Fill,
                    Height=s.SideLength,
                    Width=s.SideLength,
                    
                });

            }
        }
    }
}
