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

namespace Exercise5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int initialNo;
        static int secondNo;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            initialNo = rng.Next(1, 21);
            tblkInitialNo.Text = "Initial Number : " + initialNo.ToString();
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            Random rng2 = new Random();
            secondNo = rng2.Next(1, 21);
            bool equal = false;
            tblkSecond.Text = "Second Number : " + secondNo.ToString();

            if (secondNo == initialNo)
            {
                tblkResult.Text = "Numbers are equal, draw!";
                equal = true;
            }

            if(rdoBigger.IsChecked == true && equal == false)
            {
                if(secondNo > initialNo)
                {
                    tblkResult.Text = "You Win!";
                }
                else
                {
                    tblkResult.Text = "You Lose!";
                }
            }

            if (rdoSmaller.IsChecked == true && equal == false)
            {
                if (secondNo < initialNo)
                {
                    tblkResult.Text = "You Win!";
                }
                else
                {
                    tblkResult.Text = "You Lose!";
                }
            }
        }
    }
}
