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

namespace Exercise7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int number;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbxStartValue_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxStartValue.Clear();
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            string input = (tbxStartValue.Text).Trim();
            bool isNum = int.TryParse(input, out number);
            if(isNum)
            {
                number = int.Parse(input);
                tblkNumber.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Invalid number!");
                tbxStartValue.Clear();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            number++;
            tblkNumber.Text = number.ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            number--;
            tblkNumber.Text = number.ToString();
        }
    }
}
