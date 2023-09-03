using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        double operand1;
        double operand2;
        string operation;
        bool calc;
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public Form()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));


            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("../../Fonts/Ano-Regular.otf");

            mainLbl.Font = new Font(fontCollection.Families[0], 33);
            expressionLbl.Font = new Font(fontCollection.Families[0], 14);
            equalsLbl.Font = new Font(fontCollection.Families[0], 23);


            closeBttn.Image = Image.FromFile("../../Images/Close.bmp");
            minimizeBttn.Image = Image.FromFile("../../Images/Minimize.bmp");

            percentCstmBttn.BackgroundImage = Image.FromFile("../../Images/Percent.bmp");
            ceCstmBttn.BackgroundImage = Image.FromFile("../../Images/CE.bmp");
            cCstmBttn.BackgroundImage = Image.FromFile("../../Images/C.bmp");
            backspaceCstmBttn.BackgroundImage = Image.FromFile("../../Images/Backspace.bmp");
            reciprocalCstmBttn.BackgroundImage = Image.FromFile("../../Images/Reciprocal.bmp");
            squareCstmBttn.BackgroundImage = Image.FromFile("../../Images/Square.bmp");
            squareRootCstmBttn.BackgroundImage = Image.FromFile("../../Images/Square Root.bmp");
            divisionCstmBttn.BackgroundImage = Image.FromFile("../../Images/Divide.bmp");
            sevenCstmBttn.BackgroundImage = Image.FromFile("../../Images/Seven.bmp");
            eightCstmBttn.BackgroundImage = Image.FromFile("../../Images/Eight.bmp");
            nineCstmBttn.BackgroundImage = Image.FromFile("../../Images/Nine.bmp");
            multiplicationCstmBttn.BackgroundImage = Image.FromFile("../../Images/Multiply.bmp");
            fourCstmBttn.BackgroundImage = Image.FromFile("../../Images/Four.bmp");
            fiveCstmBttn.BackgroundImage = Image.FromFile("../../Images/Five.bmp");
            sixCstmBttn.BackgroundImage = Image.FromFile("../../Images/Six.bmp");
            subtractionCstmBttn.BackgroundImage = Image.FromFile("../../Images/Minus.bmp");
            oneCstmBttn.BackgroundImage = Image.FromFile("../../Images/One.bmp");
            twoCstmBttn.BackgroundImage = Image.FromFile("../../Images/Two.bmp");
            threeCstmBttn.BackgroundImage = Image.FromFile("../../Images/Three.bmp");
            additionCstmBttn.BackgroundImage = Image.FromFile("../../Images/Plus.bmp");
            plusMinusCstmBttn.BackgroundImage = Image.FromFile("../../Images/Plus Minus.bmp");
            zeroCstmBttn.BackgroundImage = Image.FromFile("../../Images/Zero.bmp");
            decimalPointCstmBttn.BackgroundImage = Image.FromFile("../../Images/Decimal Point.bmp");
            equalsCstmBttn.BackgroundImage = Image.FromFile("../../Images/Equals.bmp");


            calc = true;
        }


        private void closeBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBttn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void cstmBttn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            if (button.Tag.ToString() == "ce")
            {
                mainLbl.Text = "0";
                if (equalsLbl.Visible)
                {
                    equalsLbl.Visible = false;
                    expressionLbl.Visible = false;
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
                mainLbl.Text = mainLbl.Text.Remove(mainLbl.Text.Length - 1);
                if (mainLbl.Text.Length == 0)
                {
                    mainLbl.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "nine")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "9";
                }
                else
                {
                    mainLbl.Text = "9";
                }
            }
            else if (button.Tag.ToString() == "eight")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "8";
                }
                else
                {
                    mainLbl.Text = "8";
                }
            }
            else if (button.Tag.ToString() == "seven")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "7";
                }
                else
                {
                    mainLbl.Text = "7";
                }
            }
            else if (button.Tag.ToString() == "six")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "6";
                }
                else
                {
                    mainLbl.Text = "6";
                }
            }
            else if (button.Tag.ToString() == "five")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "5";
                }
                else
                {
                    mainLbl.Text = "5";
                }
            }
            else if (button.Tag.ToString() == "four")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "4";
                }
                else
                {
                    mainLbl.Text = "4";
                }
            }
            else if (button.Tag.ToString() == "three")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "3";
                }
                else
                {
                    mainLbl.Text = "3";
                }
            }
            else if (button.Tag.ToString() == "two")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "2";
                }
                else
                {
                    mainLbl.Text = "2";
                }
            }
            else if (button.Tag.ToString() == "one")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "1";
                }
                else
                {
                    mainLbl.Text = "1";
                }
            }
            else if (button.Tag.ToString() == "zero")
            {
                if (!calc)
                {
                    ResetCalculator();
                }

                if (mainLbl.Text != "0")
                {
                    mainLbl.Text += "0";
                }
            }
            else if (button.Tag.ToString() == "addition")
            {
                if (!expressionLbl.Visible)
                {
                    operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                    operation = "+";

                    expressionLbl.Visible = true;
                    expressionLbl.Text = operand1 + " +";
                    mainLbl.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "subtraction")
            {
                if (!expressionLbl.Visible)
                {
                    operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                    operation = "-";

                    expressionLbl.Visible = true;
                    expressionLbl.Text = operand1 + " -";
                    mainLbl.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "multiplication")
            {
                if (!expressionLbl.Visible)
                {
                    operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                    operation = "*";

                    expressionLbl.Visible = true;
                    expressionLbl.Text = operand1 + " ×";
                    mainLbl.Text = "0";
                }
            }
            else if (button.Tag.ToString() == "division")
            {
                if (!expressionLbl.Visible)
                {
                    operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                    operation = "/";

                    expressionLbl.Visible = true;
                    expressionLbl.Text = operand1 + " ÷";
                    mainLbl.Text = "0";
                }
            }
            else if ((button.Tag.ToString() == "equals") && calc)
            {
                operand2 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                expressionLbl.Text += " " + operand2;
                mainLbl.Text = Calculate();
                equalsLbl.Visible = true;

                calc = false;
            }
            else if ((button.Tag.ToString() == "percent") && calc)
            {
                expressionLbl.Visible = true;
                equalsLbl.Visible = true;

                string tempOperation = operation;
                if (tempOperation == "")
                {
                    expressionLbl.Text = "0";
                    mainLbl.Text = "0";
                }
                else {
                    operand2 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                    operation = "%";

                    operand2 = Convert.ToDouble(Calculate());
                    expressionLbl.Text += " " + operand2;

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
                    mainLbl.Text = Calculate();
                }

                calc = false;
            }
            else if ((button.Tag.ToString() == "reciprocal") && calc)
            {
                operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                operation = "1/";
                expressionLbl.Visible = true;
                expressionLbl.Text = "1/(" + operand1 + ")";
                mainLbl.Text = Calculate();
                equalsLbl.Visible = true;

                calc = false;
            }
            else if ((button.Tag.ToString() == "square") && calc)
            {
                operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                operation = "sqr";
                expressionLbl.Visible = true;
                expressionLbl.Text = "sqr(" + operand1 + ")";
                mainLbl.Text = Calculate();
                equalsLbl.Visible = true;

                calc = false;
            }
            else if ((button.Tag.ToString() == "squareRoot") && calc)
            {
                operand1 = Convert.ToInt32(CheckOperand(mainLbl.Text));
                operation = "sqrt";
                expressionLbl.Visible = true;
                expressionLbl.Text = "√(" + operand1 + ")";
                mainLbl.Text = Calculate();
                equalsLbl.Visible = true;

                calc = false;
            }
            else if ((button.Tag.ToString() == "plusMinus") && calc)
            {
                mainLbl.Text = (Convert.ToInt32(CheckOperand(mainLbl.Text)) * -1).ToString();
            }
            else if ((button.Tag.ToString() == "decimalPoint") && calc)
            {
                if (!mainLbl.Text.Contains("."))
                {
                    mainLbl.Text += ".";
                }
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
                return operand.Remove(mainLbl.Text.Length - 1);
            }

            return operand;
        }


        private void ResetCalculator()
        {
            mainLbl.Text = "0";
            expressionLbl.Visible = false;
            equalsLbl.Visible = false;

            operand1 = 0;
            operand2 = 0;
            operation = "";
            calc = true;
        }
    }
}
