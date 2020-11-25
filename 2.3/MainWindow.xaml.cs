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

namespace Rezisors
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            R1.IsEnabled = false;
            R2.IsEnabled = false;
        }

        private void R1_Click(object sender, RoutedEventArgs e)
        {
            if (r1.IsChecked == true) R1.IsEnabled = true;
            else R1.IsEnabled = false;
        }

        private void R2_Click(object sender, RoutedEventArgs e)
        {
            if (r2.IsChecked == true) R2.IsEnabled = true;
            else R2.IsEnabled = false;
        }

        int Mult(int a, int b)
        {
            int multA = 1;
            int multB = 1;
            while (a > 0 & b > 0)
            {
                multA *= a % 10;
                a /= 10;
                multB *= b % 10;
                b /= 10;
            }
            return multA * multB;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            int A;
            int B;
            A = int.Parse(R1.Text);
            B = int.Parse(R2.Text);
            Result.Text = Mult(A, B).ToString();
        }
    }
}
