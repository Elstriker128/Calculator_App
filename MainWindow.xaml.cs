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

namespace Calculator_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private float Output = 0f;
        public MainWindow()
        {
            InitializeComponent();
            CurrentOutput.Text = "0";
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentOutput.Clear();
            CurrentOutput.Text = "0";
        }

        private void PRButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RevButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentOutput.Text=="0")
            {
                CurrentOutput.Text = "7";
            }
            else
            {
                CurrentOutput.Text += "7";
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "8";
            }
            else
            {
                CurrentOutput.Text += "8";
            }
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "9";
            }
            else
            {
                CurrentOutput.Text += "9";
            }
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "4";
            }
            else
            {
                CurrentOutput.Text += "4";
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "5";
            }
            else
            {
                CurrentOutput.Text += "5";
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "6";
            }
            else
            {
                CurrentOutput.Text += "6";
            }
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "1";
            }
            else
            {
                CurrentOutput.Text += "1";
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "2";
            }
            else
            {
                CurrentOutput.Text += "2";
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOutput.Text == "0")
            {
                CurrentOutput.Text = "3";
            }
            else
            {
                CurrentOutput.Text += "3";
            }
        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PointButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentOutput.Text += "0";
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
