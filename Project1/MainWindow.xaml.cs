using System;
using System.Collections;
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

namespace Project1
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int operation = _operator.SelectedIndex;
                decimal xValue = Convert.ToDecimal(x.Text);
                decimal yValue = Convert.ToDecimal(y.Text);
                decimal result = 0;
                switch(operation)
                {
                    case 0:
                        result = xValue + yValue;
                        break;
                    case 1:
                        result = xValue - yValue;
                        break;
                    case 2:
                        result = xValue * yValue;
                        break;
                    case 3:
                        result = xValue / yValue;
                        break;
                    case 4:
                        result = xValue % yValue;
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No operator selected");
                        break;
                }
                equalsBox.Text = result.ToString();
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Error cannot divide by 0");

            }
        }
    }
}
