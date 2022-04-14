using System.Diagnostics;
using System.Windows;

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
            //inicio de reloj
            Stopwatch sw = Stopwatch.StartNew();
            int n1, n2, result;
            double result2;

            n1 = int.Parse(number1.Text);
            n2 = int.Parse(number2.Text);

            result = n1 + n2;

            resultsuma.Text = result.ToString();
            
            //sw.stop detiene el reloj luego del algoritmo, se pone al final
            //y se manda a mostrar luego de calcular los datos
            sw.Stop();
            //muestra los datos en milisegundos
            result2 = sw.Elapsed.TotalMilliseconds;

            resultime.Text = result2.ToString();

        }

        //limpia los textbox
        private void limpiar(object sender, RoutedEventArgs e)
        {
            number1.Text = " ";
            number2.Text = " ";
            resultsuma.Text = " ";
            resultime.Text = " ";
        }
    }
}
