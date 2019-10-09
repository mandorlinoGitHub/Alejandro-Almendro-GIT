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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var num1Text = double.TryParse(Caja1.Text.Replace('.',','), out double cifra1);
            var num2Text = double.TryParse(Caja2.Text.Replace('.', ','), out double cifra2);
            double resultado;
            if (num1Text == true && num2Text == true)
            {
                 
               resultado = cifra1 + cifra2;
                MessageBox.Show($"El resultado de la suma es: {resultado}");
            }
            else
            {
                MessageBox.Show("Debes introducir dos valores numéricos.");
            }
        }
    }
}
