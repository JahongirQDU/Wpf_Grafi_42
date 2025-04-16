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

namespace Wpf_Still_42
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += Natija_Click;
        }

        private void Natija_Click(object sender, RoutedEventArgs e)
        {
            Grafik.Children.Clear();
            Koordinata_chizish(Grafik);
        }
        
        public void Koordinata_chizish(Canvas kanvas)
        {
            double Width = kanvas.ActualWidth;
            double Height = kanvas.ActualHeight;
            double MarkazX=Width/2;
            double MarkazY=Height/2;
            double step=Width/20;

            //X o'qi
          Chizma_chizish(kanvas, 0, MarkazY, Width, MarkazY, 1);
            //Y o'qi
            Chizma_chizish(kanvas, MarkazX, 0, MarkazX, Height, 1);
            //chizizchalar chizish
            for (double x =MarkazX+ step; x < Width; x += step)
                Chizma_chizish(kanvas, x, MarkazY - 5, x, MarkazY + 5, 0.7);
            for (double x = MarkazX + step; x >0; x -= step)
                Chizma_chizish(kanvas, x, MarkazY - 5, x, MarkazY + 5, 0.7);

            for (double y = MarkazY + step; y < Height; y += step)
                Chizma_chizish(kanvas, MarkazX-5, y, MarkazX+5, y, 0.7);
            for (double y = MarkazY + step; y >0; y -= step)
                Chizma_chizish(kanvas, MarkazX - 5, y, MarkazX + 5, y, 0.7);

            //uchini chizish
            Chizma_chizish(kanvas, MarkazX - 10, 10, MarkazX , 0, 1);
            Chizma_chizish(kanvas, MarkazX +10, 10, MarkazX, 0, 1);
            Chizma_chizish(kanvas, Width-10, MarkazY-10, Width, MarkazY, 1);
            Chizma_chizish(kanvas, Width - 10, MarkazY + 10, Width, MarkazY, 1);

        }

        public void Chizma_chizish(Canvas kanvas,double x1,double y1,
            double x2,double y2,double size) {
            Line line = new Line
            {
                X1 = x1, Y1 = y1,
                X2 = x2, Y2 = y2,
                Stroke = Brushes.Black,
                StrokeThickness = size
        } ;
            kanvas.Children.Add(line);
        }


    }
}
