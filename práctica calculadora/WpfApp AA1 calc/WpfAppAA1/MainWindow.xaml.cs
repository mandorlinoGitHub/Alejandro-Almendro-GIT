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

namespace WpfAppAA1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool num1Check = double.TryParse(Box1Input.Text.Replace('.', ','), out double finalNum1);
            bool num2Check = double.TryParse(Box2Input.Text.Replace('.', ','), out double finalNum2);
           
            if (num1Check == true && num2Check == true)
            {
                double result = finalNum1 + finalNum2;
                MessageBox.Show($"El resultado de la suma es: {result}");
            }
            else
            {
                MessageBox.Show("Debes introducir dos valores numéricos.");
            }
        }
    }
}
