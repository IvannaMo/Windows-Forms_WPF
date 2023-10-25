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

namespace Calculator_pt._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double operand1;
        private double operand2;
        private string operation;
        private bool calc;


        public MainWindow()
        {
            InitializeComponent();


            MouseDown += MainWindow_MouseDown;


            operand1 = 0;
            operand2 = 0;
            calc = true;
        }


        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }


        private void minimizeBttn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void closeBttn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;


            if (button.Tag.ToString() == "ce")
            {
                mainTxtBlck.Text = "0";
                if (equalsBttn.IsVisible)
                {
                    expressionTxtBlck.Visibility = Visibility.Hidden;
                }

                operand1 = 0;
                operand2 = 0;
                operation = "";
                calc = true;
            }
            else if (button.Tag.ToString() == "c")
            {
                ResetCalculator();
            }
            else if ((button.Tag.ToString() == "backspace") && calc)
            {
                mainTxtBlck.Text = mainTxtBlck.Text.Remove(mainTxtBlck.Text.Length - 1);
                if (mainTxtBlck.Text.Length == 0)
                {
                    mainTxtBlck.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "nine")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "9";
                }
                else
                {
                    mainTxtBlck.Text = "9";
                }
            }
            else if (button.Tag.ToString() == "eight")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "8";
                }
                else
                {
                    mainTxtBlck.Text = "8";
                }
            }
            else if (button.Tag.ToString() == "seven")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "7";
                }
                else
                {
                    mainTxtBlck.Text = "7";
                }
            }
            else if (button.Tag.ToString() == "six")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "6";
                }
                else
                {
                    mainTxtBlck.Text = "6";
                }
            }
            else if (button.Tag.ToString() == "five")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "5";
                }
                else
                {
                    mainTxtBlck.Text = "5";
                }
            }
            else if (button.Tag.ToString() == "four")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "4";
                }
                else
                {
                    mainTxtBlck.Text = "4";
                }
            }
            else if (button.Tag.ToString() == "three")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "3";
                }
                else
                {
                    mainTxtBlck.Text = "3";
                }
            }
            else if (button.Tag.ToString() == "two")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "2";
                }
                else
                {
                    mainTxtBlck.Text = "2";
                }
            }
            else if (button.Tag.ToString() == "one")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "1";
                }
                else
                {
                    mainTxtBlck.Text = "1";
                }
            }
            else if (button.Tag.ToString() == "zero")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text += "0";
                }
            }
            else if ((button.Tag.ToString() == "percent") && calc)
            {
                expressionTxtBlck.Visibility = Visibility.Visible;

                string tempOperation = operation;
                if (tempOperation == "")
                {
                    expressionTxtBlck.Text = "0";
                    mainTxtBlck.Text = "0";
                }
                else
                {
                    operand2 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                    operation = "%";

                    operand2 = Convert.ToDouble(Calculate());
                    expressionTxtBlck.Text += " " + operand2;

                    switch (tempOperation)
                    {
                        case "+":
                            operation = "+";
                            break;
                        case "-":
                            operation = "-";
                            break;
                        case "*":
                            operation = "*";
                            break;
                        case "/":
                            operation = "/";
                            break;
                    }
                    mainTxtBlck.Text = Calculate();
                }

                calc = false;
            }
            else if ((button.Tag.ToString() == "reciprocal") && calc)
            {
                operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                operation = "1/";
                expressionTxtBlck.Visibility = Visibility.Visible;
                expressionTxtBlck.Text = "1/(" + operand1 + ")";
                mainTxtBlck.Text = Calculate();

                calc = false;
            }
            else if ((button.Tag.ToString() == "square") && calc)
            {
                operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                operation = "sqr";
                expressionTxtBlck.Visibility = Visibility.Visible;
                expressionTxtBlck.Text = "sqr(" + operand1 + ")";
                mainTxtBlck.Text = Calculate();

                calc = false;
            }
            else if ((button.Tag.ToString() == "squareRoot") && calc)
            {
                operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                operation = "sqrt";
                expressionTxtBlck.Visibility = Visibility.Visible;
                expressionTxtBlck.Text = "√(" + operand1 + ")";
                mainTxtBlck.Text = Calculate();

                calc = false;
            }
            else if ((button.Tag.ToString() == "plusMinus") && calc)
            {
                if (mainTxtBlck.Text != "0")
                {
                    mainTxtBlck.Text = (Convert.ToDouble(CheckOperand(mainTxtBlck.Text)) * -1).ToString();
                }
            }
            else if ((button.Tag.ToString() == "decimalPoint") && calc)
            {
                if (!mainTxtBlck.Text.Contains("."))
                {
                    mainTxtBlck.Text += ".";
                }
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;


            if (button.Tag.ToString() == "addition")
            {
                if (!expressionTxtBlck.IsVisible)
                {
                    operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                    operation = "+";

                    expressionTxtBlck.Visibility = Visibility.Visible;
                    expressionTxtBlck.Text = operand1 + " +";
                    mainTxtBlck.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "subtraction")
            {
                if (!expressionTxtBlck.IsVisible)
                {
                    operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                    operation = "-";

                    expressionTxtBlck.Visibility = Visibility.Visible;
                    expressionTxtBlck.Text = operand1 + " -";
                    mainTxtBlck.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "multiplication")
            {
                if (!expressionTxtBlck.IsVisible)
                {
                    operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                    operation = "*";

                    expressionTxtBlck.Visibility = Visibility.Visible;
                    expressionTxtBlck.Text = operand1 + " ×";
                    mainTxtBlck.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "division")
            {
                if (!expressionTxtBlck.IsVisible)
                {
                    operand1 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                    operation = "/";

                    expressionTxtBlck.Visibility = Visibility.Visible;
                    expressionTxtBlck.Text = operand1 + " ÷";
                    mainTxtBlck.Text = "0";
                }
            }
        }

        private void EqualscButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;


            if ((button.Tag.ToString() == "equals") && calc)
            {
                operand2 = Convert.ToDouble(CheckOperand(mainTxtBlck.Text));
                expressionTxtBlck.Text += " " + operand2;
                mainTxtBlck.Text = Calculate();

                calc = false;
            }
        }


        private string Calculate()
        {
            double result = 0;
            if (operation == "+")
            {
                result = operand1 + operand2;
            }
            else if (operation == "-")
            {
                result = operand1 - operand2;
            }
            else if (operation == "*")
            {
                result = operand1 * operand2;
            }
            else if (operation == "/")
            {
                if (operand2 != 0)
                {
                    result = operand1 / operand2;
                }
                else
                {
                    return "Error";
                }
            }
            else if (operation == "%")
            {
                result = operand1 * operand2 / 100;
            }
            else if (operation == "1/")
            {
                if (operand1 != 0)
                {
                    result = 1 / operand1;
                }
                else
                {
                    return "Error";
                }
            }
            else if (operation == "sqr")
            {
                result = operand1 * operand1;
            }
            else if (operation == "sqrt")
            {
                result = Math.Sqrt(operand1);
            }

            return result.ToString();
        }


        private string CheckOperand(string operand)
        {
            if (operand.EndsWith("."))
            {
                return operand.Remove(mainTxtBlck.Text.Length - 1);
            }

            return operand;
        }


        private void ResetCalculator()
        {
            mainTxtBlck.Text = "0";
            expressionTxtBlck.Visibility = Visibility.Hidden;

            operand1 = 0;
            operand2 = 0;
            operation = "";
            calc = true;
        }
    }
}
