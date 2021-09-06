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

namespace Lesson_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            if (sender is Button btn)
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(((byte)rand.Next(255)), ((byte)rand.Next(255)), ((byte)rand.Next(255))));
                MessageBox.Show(btn.Content.ToString());
            }

        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Visibility = Visibility.Hidden;
                if (Title != "MainWindow") Title += btn.Content.ToString();
                else Title = btn.Content.ToString();
            }
        }
    }
}
