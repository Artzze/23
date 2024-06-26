using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace эээ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Polygon T = new Polygon();
        Polygon I = new Polygon();
        Polygon K = new Polygon();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создатель: Таут\nВариант: 7\nЗадача: Вывести на экран слово ТИК. При построении букв использовать разные графические примитивы", "О программе");
        }

        private void Draw(object sender, RoutedEventArgs e)
        {
            T.StrokeThickness = 2;
            T.Stroke = Brushes.Black;
            T.Points.Add(new Point(10, 50));
            T.Points.Add(new Point(100, 50));
            T.Points.Add(new Point(100, 80));
            T.Points.Add(new Point(70, 80));
            T.Points.Add(new Point(70, 180));
            T.Points.Add(new Point(40, 180));
            T.Points.Add(new Point(40, 80));
            T.Points.Add(new Point(10, 80));
            canvas.Children.Add(T);

            I.StrokeThickness = 2;
            I.Stroke = Brushes.Black;
            I.Points.Add(new Point(110, 50));
            I.Points.Add(new Point(110, 180));
            I.Points.Add(new Point(130, 180));
            I.Points.Add(new Point(130, 160));
            I.Points.Add(new Point(160, 130));
            I.Points.Add(new Point(160, 180));
            I.Points.Add(new Point(180, 180));
            I.Points.Add(new Point(180, 50));
            I.Points.Add(new Point(160, 50));
            I.Points.Add(new Point(160, 100));
            I.Points.Add(new Point(130, 130));
            I.Points.Add(new Point(130, 50));
            canvas.Children.Add(I);

            K.StrokeThickness = 2;
            K.Stroke = Brushes.Black;
            K.Points.Add(new Point(190,50));
            K.Points.Add(new Point(190,180));
            K.Points.Add(new Point(210,180));
            K.Points.Add(new Point(210,150));
            K.Points.Add(new Point(225,130));
            K.Points.Add(new Point(250,180));
            K.Points.Add(new Point(270,180));
            K.Points.Add(new Point(235,115));
            K.Points.Add(new Point(270,50));
            K.Points.Add(new Point(250,50));
            K.Points.Add(new Point(210,110));
            K.Points.Add(new Point(210,50));
            canvas.Children.Add(K);
        }

        private void Aqua(object sender, MouseButtonEventArgs e)
        {
            if (canvas.Children.Count != 0)
            {
                T.Fill = Brushes.Aqua;
                I.Fill = Brushes.Aqua;
                K.Fill = Brushes.Aqua;
            }
            else
            {
                MessageBox.Show("Фигура не нарисована", "Ошибка");
            }
        }

        private void Pink(object sender, MouseButtonEventArgs e)
        {
            if (canvas.Children.Count != 0)
            {
                T.Fill = Brushes.Pink;
                I.Fill = Brushes.Pink;
                K.Fill = Brushes.Pink;
            }
            else
            {
                MessageBox.Show("Фигура не нарисована", "Ошибка");
            }
        }

        private void Green(object sender, MouseButtonEventArgs e)
        {
            if (canvas.Children.Count != 0)
            {
                T.Fill = Brushes.Green;
                I.Fill = Brushes.Green;
                K.Fill = Brushes.Green;
            }
            else
            {
                MessageBox.Show("Фигура не нарисована", "Ошибка");
            }
        }

        private void Yellow(object sender, MouseButtonEventArgs e)
        {
            if (canvas.Children.Count != 0)
            {
                T.Fill = Brushes.Yellow;
                I.Fill = Brushes.Yellow;
                K.Fill = Brushes.Yellow;
            }
            else
            {
                MessageBox.Show("Фигура не нарисована", "Ошибка");
            }
        }

        private void Red(object sender, MouseButtonEventArgs e)
        {
            if (canvas.Children.Count != 0)
            {
                T.Fill = Brushes.Red;
                I.Fill = Brushes.Red;
                K.Fill = Brushes.Red;
            }
            else
            {
                MessageBox.Show("Фигура не нарисована", "Ошибка");
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Colours.Text = null;
        }
    }
}