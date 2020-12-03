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

namespace Exercise4
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

        private void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            //read number
            string input = (tbxInput.Text).Trim();

            //check if valid number
            int number;
            bool isNum = int.TryParse(input, out number);

            //display appropriate message
            if (isNum)
            {
                MessageBox.Show("Value entered is a valid number");
                tbxInput.Background = Brushes.Green;
            }
            else
            {
                MessageBox.Show("Value entered is not a valid number");
                tbxInput.Background = Brushes.Red;
            }
        }
    }
}
