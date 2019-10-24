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

namespace WpfApp_AA1_calc_compleja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        float primerNumero = 0;
        float segundoNumero = 0;
        string operador = "";

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "")
            {
                primerNumero = (primerNumero * 10) + 1;
                Display.Text = primerNumero.ToString();
            }
            else
            {
                segundoNumero = (segundoNumero * 10) + 1;
                Display.Text = segundoNumero.ToString();
            }
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "")
            {
                primerNumero = (primerNumero * 10) + 2;
                Display.Text = primerNumero.ToString();
            }
            else
            {
                segundoNumero = (segundoNumero * 10) + 2;
                Display.Text = segundoNumero.ToString();
            }
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "")
            {
                primerNumero = (primerNumero * 10) + 3;
                Display.Text = primerNumero.ToString();
            }
            else
            {
                segundoNumero = (segundoNumero * 10) + 3;
                Display.Text = segundoNumero.ToString();
            }
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "")
            {
                primerNumero = (primerNumero * 10) + 4;
                Display.Text = primerNumero.ToString();
            }
            else
            {
                segundoNumero = (segundoNumero * 10) + 4;
                Display.Text = segundoNumero.ToString();
            }
        }
    }
}
