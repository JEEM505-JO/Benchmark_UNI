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
using System.Diagnostics;
using System.Threading;

namespace Benchmark_UNI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int n1, n2, result;
            double result2;

            n1 = int.Parse(number1.Text);
            n2 = int.Parse(number2.Text);

            result = n1 + n2;

            resultsuma.Text = result.ToString();
            sw.Stop();
            result2 = sw.Elapsed.TotalMilliseconds;

            resultime.Text = result2.ToString();
            
        }

        private void limpiar(object sender, RoutedEventArgs e)
        {
            number1.Text = " ";
            number2.Text = " ";
            resultsuma.Text = " ";
            resultime.Text = " ";
        }
    }
}
