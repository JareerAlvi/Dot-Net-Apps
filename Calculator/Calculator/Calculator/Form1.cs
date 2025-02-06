using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void InputDisplayBox_TextChanged(object sender, EventArgs e)
        {
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
            InputDisplayBox.SelectionStart = InputDisplayBox.Text.Length;  // Keep cursor at the end
        }


        public static long FirstNumber;
        public static long SecondNumber;
        public static decimal DFirstNumber;
        public static decimal DSecondNumber;
        public static bool initial_click = false;
        public static char operator_click = ' ';
        public static bool initial_click2 = false;
        public static string type;
        
        private void ModBtn_Click(object sender, EventArgs e)
        {
            operator_click = '%';
            string DisplayTBinput = InputDisplayBox.Text.ToString().Trim();
            long.TryParse(DisplayTBinput, out  FirstNumber);
            if (decimal.TryParse(DisplayTBinput, out DFirstNumber)) type = "D";
            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + "% 0 ";
            }
            else {
                resultTextBox.Text = " = %  " + InputDisplayBox.Text ;
            }
            InputDisplayBox.Text = "0";
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }



        private void EqualsToBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = InputDisplayBox.Text.ToString().Trim();

            // Try parsing as long by default
            long.TryParse(DisplayTBinput, out SecondNumber);

            if (SecondNumber == 0 && (operator_click == '%' || operator_click == '/' || operator_click == '*'))
            {
                resultTextBox.Text = "Cannot Divide by Zero or Multiply by Zero";
                return;
            }

            // Handle different operators
            if (operator_click == '%')
            {
                if (type == "D")
                {
                    decimal DSecondNumber = 0;
                    if (decimal.TryParse(DisplayTBinput, out DSecondNumber))
                    {
                        InputDisplayBox.Text = (DFirstNumber % DSecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
                    }
                    else
                    {
                        InputDisplayBox.Text = (FirstNumber % SecondNumber).ToString();
                        resultTextBox.Text = FirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                    }
                }
                else
                {
                    InputDisplayBox.Text = (FirstNumber % SecondNumber).ToString();
                    resultTextBox.Text = FirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                }
            }
            else if (operator_click == '+')
            {
                if (type == "D")
                {
                    decimal DSecondNumber = 0;
                    if (decimal.TryParse(DisplayTBinput, out DSecondNumber))
                    {
                        InputDisplayBox.Text = (DFirstNumber + DSecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
                    }
                    else
                    {
                        InputDisplayBox.Text = (DFirstNumber + SecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                    }
                }
                else
                {
                    InputDisplayBox.Text = (FirstNumber + SecondNumber).ToString();
                    resultTextBox.Text = FirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                }
            }
            else if (operator_click == '-')
            {
                if (type == "D")
                {
                    decimal DSecondNumber = 0;
                    if (decimal.TryParse(DisplayTBinput, out DSecondNumber))
                    {
                        InputDisplayBox.Text = (DFirstNumber - DSecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
                    }
                    else
                    {
                        InputDisplayBox.Text = (DFirstNumber - SecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                    }
                }
                else
                {
                    InputDisplayBox.Text = (FirstNumber - SecondNumber).ToString();
                    resultTextBox.Text = FirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                }
            }
            else if (operator_click == '/')
            {
                if (type == "D")
                {
                    decimal DSecondNumber = 0;
                    if (decimal.TryParse(DisplayTBinput, out DSecondNumber))
                    {
                        if (DSecondNumber == 0)
                        {
                            resultTextBox.Text = "Cannot Divide by Zero";
                            return;
                        }
                        InputDisplayBox.Text = (DFirstNumber / DSecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
                    }
                    else
                    {
                        if (SecondNumber == 0)
                        {
                            resultTextBox.Text = "Cannot Divide by Zero";
                            return;
                        }
                        InputDisplayBox.Text = (DFirstNumber / SecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                    }
                }
                else
                {
                    if (SecondNumber == 0)
                    {
                        resultTextBox.Text = "Cannot Divide by Zero";
                        return;
                    }
                    InputDisplayBox.Text = (FirstNumber / (decimal)SecondNumber).ToString(); // Convert to decimal for division
                    resultTextBox.Text = FirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                }
            }
            else if (operator_click == 'x')
            {
                if (type == "D")
                {
                    decimal DSecondNumber = 0;
                    if (decimal.TryParse(DisplayTBinput, out DSecondNumber))
                    {
                        InputDisplayBox.Text = (DFirstNumber * DSecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
                    }
                    else
                    {
                        InputDisplayBox.Text = (DFirstNumber * SecondNumber).ToString();
                        resultTextBox.Text = DFirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                    }
                }
                else
                {
                    InputDisplayBox.Text = (FirstNumber * SecondNumber).ToString();
                    resultTextBox.Text = FirstNumber.ToString() + operator_click + SecondNumber.ToString() + "=";
                }
            }

            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment
            resultTextBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment
            InputDisplayBox.ScrollBars = RichTextBoxScrollBars.None; // Disable scrolling
            resultTextBox.ScrollBars = RichTextBoxScrollBars.None; // Disable scrolling
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "1"; // Replace 0 with the new number
            }
            else if (InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "1";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "2"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "2";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "3"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "3";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "4"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "4";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "5"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "5";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "6"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "6";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "7"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "7";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "8"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "8";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text == "0")
            {
                InputDisplayBox.Text = "9"; // Replace 0 with the new number
            }
            else if(InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "9";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (InputDisplayBox.Text=="0")
            {
                return;
            }
           if (InputDisplayBox.Text.Length <= 14)
            {
                InputDisplayBox.Text += "0";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            operator_click = '+';
            string DisplayTBinput = InputDisplayBox.Text.ToString().Trim();
            long.TryParse(DisplayTBinput, out FirstNumber);
            if(decimal.TryParse(DisplayTBinput, out  DFirstNumber))type="D";
            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + "+ 0 ";
            }
            else
            {
                resultTextBox.Text = " = +  " + InputDisplayBox.Text;
            }
            InputDisplayBox.Text = "0"; InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            operator_click = '-';
            string DisplayTBinput = InputDisplayBox.Text.ToString().Trim();
            long.TryParse(DisplayTBinput, out FirstNumber);
            if (decimal.TryParse(DisplayTBinput, out DFirstNumber)) type = "D";
            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + "- 0 ";
            }
            else
            {
                resultTextBox.Text = " = -  " + InputDisplayBox.Text;
            }
            InputDisplayBox.Text = "0"; InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }

        private void DivsionBtn_Click(object sender, EventArgs e)
        {
            operator_click = '/';
            string DisplayTBinput = InputDisplayBox.Text.ToString().Trim();
            long.TryParse(DisplayTBinput, out FirstNumber);
            if (decimal.TryParse(DisplayTBinput, out DFirstNumber)) type = "D";
            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + "÷ 0 ";
            }
            else
            {
                resultTextBox.Text = " = ÷  " + InputDisplayBox.Text;
            }
            InputDisplayBox.Text = "0"; InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment

        }
        private void NegateBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = InputDisplayBox.Text.Trim();

            if (DisplayTBinput == "0") return; 

            if (!DisplayTBinput.StartsWith("-"))
            {
                InputDisplayBox.Text = "-" + DisplayTBinput;
            }
            else
            {
                InputDisplayBox.Text = DisplayTBinput.Substring(1); // Remove the negative sign
            }

            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; 
        }

        private void ReciprocalBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = InputDisplayBox.Text.Trim();

            decimal.TryParse(DisplayTBinput, out decimal FirstNumber);
 

            if (FirstNumber == 0)
            {
                resultTextBox.Text = "Cannot Divide By Zero";
                return;
            }

            decimal reciprocal = 1 / FirstNumber;
            resultTextBox.Text = $"1/({FirstNumber}) = {reciprocal}";
            InputDisplayBox.Text = reciprocal.ToString();

            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment
            InputDisplayBox.ScrollBars = RichTextBoxScrollBars.None; // Disable scrolling
            resultTextBox.ScrollBars = RichTextBoxScrollBars.None; // Disable scrolling

        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = InputDisplayBox.Text.Trim();

            double.TryParse(DisplayTBinput, out double FirstNumber);
            if (decimal.TryParse(DisplayTBinput, out DFirstNumber)) type = "D";
            if (type == "D") {

                resultTextBox.Text = $"sqr({DFirstNumber}) =";
                InputDisplayBox.Text = (DFirstNumber * DFirstNumber).ToString();
            }
            else
            {
                resultTextBox.Text = $"sqr({FirstNumber}) =";
                InputDisplayBox.Text = (FirstNumber * FirstNumber).ToString();
            }

            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment
            InputDisplayBox.ScrollBars = RichTextBoxScrollBars.None; // Disable scrolling
            resultTextBox.ScrollBars = RichTextBoxScrollBars.None; // Disable scrolling
        }

        private void SqRootBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = InputDisplayBox.Text.Trim();

            double.TryParse(DisplayTBinput, out double FirstNumber);
            if (decimal.TryParse(DisplayTBinput, out DFirstNumber))
                type = "D";

            if (type == "D")
            {
                // Handle the square root for decimal input
                resultTextBox.Text = $"√({DFirstNumber}) =";
                InputDisplayBox.Text = (Math.Sqrt((double)DFirstNumber)).ToString(); // Convert decimal to double for Math.Sqrt
            }
            else
            {
                resultTextBox.Text = $"√({FirstNumber}) =";
                InputDisplayBox.Text = (Math.Sqrt(FirstNumber)).ToString();
            }
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
            InputDisplayBox.ScrollBars = RichTextBoxScrollBars.None; 
            resultTextBox.ScrollBars = RichTextBoxScrollBars.None; 
        }


        private void DecimalBtn_Click(object sender, EventArgs e)
        {
 
            if (InputDisplayBox.Text.Length <= 14 && !InputDisplayBox.Text.Contains("."))
            {
                InputDisplayBox.Text += ".";
            }

            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            operator_click = 'x';
            string DisplayTBinput = InputDisplayBox.Text.ToString().Trim();
            long.TryParse(DisplayTBinput, out FirstNumber);

            if (decimal.TryParse(DisplayTBinput, out DFirstNumber))
                type = "D";

            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + "x 0 ";
            }
            else
            {
                resultTextBox.Text = " = x  " + InputDisplayBox.Text;
            }

            InputDisplayBox.Text = "0";
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right; // Ensure right alignment
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = InputDisplayBox.Text.Trim();

            if (DisplayTBinput == "0") return;

            if (DisplayTBinput.Length > 0)
            {
                DisplayTBinput = DisplayTBinput.Substring(0, DisplayTBinput.Length - 1);
            }
            if (string.IsNullOrEmpty(DisplayTBinput))
            {
                DisplayTBinput = "0";
            }
            InputDisplayBox.Text = DisplayTBinput;

            // Ensure right alignment
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
        }



        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputDisplayBox.Text = "0";
            resultTextBox.Text = "";
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ClearBtn2_Click(object sender, EventArgs e)
        {
            InputDisplayBox.Text = "0";
            resultTextBox.Text = "";
            InputDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
