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

namespace AppGui2
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

        private void lstDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem select = (lstDatos.SelectedItem as ListBoxItem);
            switch(select.Content.ToString())
            {
                case "Int":
                    showIntValue();
                    break;
                case "Long":
                    showLongValue();
                    break;
                case "Float":
                    showFloatValue();
                    break;
                case "Double":
                    showDoubleValue();
                    break;
                case "Decimal":
                    showDecimalValue();
                    break;
                case "String":
                    showString();
                    break;
                case "Char":
                    showCharValue();
                    break;
                case "Bool":
                    showBoolValue();
                    break;

            }
        }


        private void showIntValue()
        {
            int intValor;
            intValor = 9;
            txtValor.Text = intValor.ToString();
        }
        private void showFloatValue()
        {
            float floatVar;
            floatVar = 0.42f;
            txtValor.Text = floatVar.ToString();
        }
        private void showLongValue()
        {
            long longVar;
            longVar = 521;
            txtValor.Text = longVar.ToString();
        }
        private void showDoubleValue() 
        {
            double doubleVar;
            doubleVar = 120;
            txtValor.Text = doubleVar.ToString();
        }
        private void showDecimalValue()
        {
            decimal decimalVar;
            decimalVar = 0.42M;
            txtValor.Text = decimalVar.ToString();
        }
        private void showString()
        {
            String stringVar;
            stringVar = "cuarenta y tres";
            txtValor.Text = stringVar;
        }
        private void showCharValue()
        {
            char charVar;
            charVar = 'x';
            txtValor.Text = charVar.ToString();
        }
        private void showBoolValue()
        {
            Boolean boolVar;
            boolVar = true;
            txtValor.Text = boolVar.ToString();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
