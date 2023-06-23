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
        /// <summary>
        /// Declaration of the values that are going to be used when using operators
        /// </summary>
        private decimal FirstValue = 0;
        private decimal SecondValue = 0;
        private decimal FinalValue = 0;
        private string oper = "+";
        public MainWindow()
        {
            InitializeComponent();
            //Make it so you can't type in the output box
            CurrentOutput.IsReadOnly= true;
            //When you launch the program you see a zero in the textbox
            CurrentOutput.Text = "0";
        }
        /// <summary>
        /// A method that initiates when you press the clear button "C" on the calculator
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentOutput.Clear();
            CurrentOutput.Text = "0";
            MemoryOutput.Content=string.Empty;
        }
        /// <summary>
        /// A method that initiates when you press the remainder button "%" on the calculator. It helps you calculate the remainder of a number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void PRButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryOutput.Content= CurrentOutput.Text + " %";
            FirstValue = decimal.Parse(CurrentOutput.Text);
            CurrentOutput.Text = "0";
            oper = "%";
        }
        /// <summary>
        /// A method that initiates when you press the division button "/" on the calculator. It helps you calculate the division of a number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryOutput.Content = CurrentOutput.Text + " /";
            FirstValue = decimal.Parse(CurrentOutput.Text);
            CurrentOutput.Text = "0";
            oper = "/";

        }
        /// <summary>
        /// A method that initiates when you press the deletion button "←" on the calculator. It deletes a single number from the calculator's textbox.
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void RevButton_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentOutput.Text == "0")
            {
                return;
            }
            if(CurrentOutput.Text != "0" && CurrentOutput.Text.Length>=1)
            {
                CurrentOutput.Text = CurrentOutput.Text.Remove(CurrentOutput.Text.Length - 1);
            }
            if(CurrentOutput.Text.Length==0)
            {
                CurrentOutput.Text = "0";
                return;
            }
        }
        /// <summary>
        /// A method that initiates when you press the subtraction button "-" on the calculator. It helps you calculate the subtraction of a number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryOutput.Content = CurrentOutput.Text + " -";
            FirstValue = decimal.Parse(CurrentOutput.Text);
            CurrentOutput.Text = "0";
            
            oper = "-";
        }
        /// <summary>
        /// A method that initiates when you press the addition button "+" on the calculator. It helps you calculate the addition of a number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryOutput.Content = CurrentOutput.Text + " +";
            FirstValue = decimal.Parse(CurrentOutput.Text);
            CurrentOutput.Text = "0";
            
            oper = "+";
        }
        /// <summary>
        /// A method that initiates when you press the multiplication button "x" on the calculator. It helps you calculate the multiplied number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryOutput.Content = CurrentOutput.Text + " x";
            FirstValue = decimal.Parse(CurrentOutput.Text);
            CurrentOutput.Text = "0";
            
            oper = "*";
        }
        /// <summary>
        /// A method that initiates when you press the point button "." on the calculator. It helps you add a point to a number to transform it into a decimal number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentOutput.Text += ".";
        }
        /// <summary>
        /// A method that initiates when you press the plus or minus button "+/-" on the calculator. It helps you transform the number into either a negative or positive version of itself
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void PlusMinButton_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentOutput.Text.Contains("-"))
            {
                CurrentOutput.Text = CurrentOutput.Text.Trim('-');
            }
            else
            {
                CurrentOutput.Text = "-" + CurrentOutput.Text;
            }
        }
        /// <summary>
        /// A method that initiates when you press the equals button "=" on the calculator. It helps you calculate the desired number using the used numbers values and operators
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryOutput.Content = string.Empty;
            switch(oper)
            {
                case "+":
                    SecondValue = decimal.Parse(CurrentOutput.Text);
                    FinalValue = FirstValue + SecondValue;
                    CurrentOutput.Text = FinalValue.ToString();
                    break;
                case "-":
                    SecondValue = decimal.Parse(CurrentOutput.Text);
                    FinalValue = FirstValue - SecondValue;
                    CurrentOutput.Text = FinalValue.ToString();
                    break;
                case "*":
                    SecondValue = decimal.Parse(CurrentOutput.Text);
                    FinalValue = FirstValue * SecondValue;
                    CurrentOutput.Text = FinalValue.ToString();
                    break;
                case "/":
                    SecondValue = decimal.Parse(CurrentOutput.Text);
                    if (SecondValue != 0)
                    {

                        FinalValue = FirstValue / SecondValue;
                        CurrentOutput.Text = FinalValue.ToString();
                        break;
                    }
                    else
                    {
                        MemoryOutput.Content = "Can't divide by 0";
                        break;
                    }
                case "%":
                    SecondValue = decimal.Parse(CurrentOutput.Text);
                    if(SecondValue != 0)
                    {
                        FinalValue = FirstValue % SecondValue;
                        CurrentOutput.Text = FinalValue.ToString();
                        break;
                    }
                    else
                    {
                        MemoryOutput.Content = "Can't divide by 0";
                        break;
                    }
            }
        }
        /// <summary>
        /// A method that initiates when you press the number 1 button "1" on the calculator. It helps you add the number 1 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 2 button "2" on the calculator. It helps you add the number 2 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 3 button "3" on the calculator. It helps you add the number 3 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 4 button "4" on the calculator. It helps you add the number 4 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 5 button "5" on the calculator. It helps you add the number 5 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 6 button "6" on the calculator. It helps you add the number 6 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 7 button "7" on the calculator. It helps you add the number 7 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 8 button "8" on the calculator. It helps you add the number 8 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 9 button "9" on the calculator. It helps you add the number 9 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
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
        /// <summary>
        /// A method that initiates when you press the number 0 button "0" on the calculator. It helps you add the number 0 to the overall number or start a new number
        /// </summary>
        /// <param name="sender">an object of the object class</param>
        /// <param name="e">an object of the RoutedEventArgs event</param>
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentOutput.Text += "0";
        }
    }
}
