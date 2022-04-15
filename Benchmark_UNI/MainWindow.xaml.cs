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
            long n1, n2, result; // cambiamos el tipo de variable a long, para hacer pruebas con cantidades grandes
            int contador = 0;
            double result2;

            n1 = long.Parse(number1.Text);
            n2 = long.Parse(number2.Text);

            // obtener el producto de dos numeros mediante una sucesion
            // inicio del cambio

            while (contador < n2) {

                result += n1;
                contador++;
            }
            // fin del cambio

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
