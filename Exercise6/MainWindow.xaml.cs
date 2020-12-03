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

namespace Exercise6
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

        private void tbxInput_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxInput.Clear();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string input = (tbxInput.Text).Trim();
            int number;

            bool isNumber = int.TryParse(input, out number);
            if(isNumber)
            {
                number = int.Parse(input);

                if ((number % 2) != 0)
                {
                    tblkResult.Text = "Number is odd.";
                    tblkResult.Background = Brushes.Red;
                }
                else
                {
                    tblkResult.Text = "Number is even.";
                    tblkResult.Background = Brushes.Green;
                }

            }
            else
            {
                tblkResult.Text = "Not a valid number, try again.";
                tblkResult.Background = Brushes.Orange;
            }
        }
    }
}
