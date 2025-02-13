using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double DFirstNumber;
        public static double DSecondNumber;
        public static char operator_click = ' ';

        private void ModBtn_Click(object sender, EventArgs e)
        {
            operator_click = '%';
            string DisplayTBinput = tbInput.Text.ToString().Trim();
            double.TryParse(DisplayTBinput, out DFirstNumber);
            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + "% 0 ";
            }
            else
            {
                resultTextBox.Text = " = %  " + tbInput.Text;
            }
            tbInput.Text = "0";
        }

        private void EqualsToBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = tbInput.Text.ToString().Trim();
            double.TryParse(DisplayTBinput, out DSecondNumber);

            if (DSecondNumber == 0 && (operator_click == '%' || operator_click == '/'))
            {
                resultTextBox.Text = "Cannot Divide by Zero or Multiply by Zero";
                return;
            }

            // Handle different operators
            if (operator_click == '%')
            {
                tbInput.Text = (DFirstNumber % DSecondNumber).ToString();
                resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
            }
            else if (operator_click == '+')
            {
                tbInput.Text = (DFirstNumber + DSecondNumber).ToString();
                resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
            }
            else if (operator_click == '-')
            {
                tbInput.Text = (DFirstNumber - DSecondNumber).ToString();
                resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
            }
            else if (operator_click == '/')
            {
                if (DSecondNumber == 0)
                {
                    resultTextBox.Text = "Cannot Divide by Zero";
                    return;
                }
                tbInput.Text = (DFirstNumber / DSecondNumber).ToString();
                resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
            }
            else if (operator_click == 'x')
            {
                tbInput.Text = (DFirstNumber * DSecondNumber).ToString();
                resultTextBox.Text = DFirstNumber.ToString() + operator_click + DSecondNumber.ToString() + "=";
            }
        }

        private void SetInput(string input)
        {
            if (tbInput.Text == "0")
            {
                tbInput.Text = input; // Replace 0 with the new number
            }
            else if (tbInput.Text.Length <= 14)
            {
                tbInput.Text += input;
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (operator_click != ' ')
                tbInput.Clear();

            Button btn = sender as Button;
            SetInput(btn.Text);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "0")
            {
                return;
            }
            if (tbInput.Text.Length <= 14)
            {
                tbInput.Text += "0";
            }
            else
            {
                resultTextBox.Text = "Number Size Limit Reached";
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operator_click = Convert.ToChar(btn.Text.Trim());
            string DisplayTBinput = tbInput.Text.ToString().Trim();
            double.TryParse(DisplayTBinput, out DFirstNumber);
            if (DisplayTBinput == "0")
            {
                resultTextBox.Text = "= 0 " + operator_click + " 0 ";
            }
            else
            {
                resultTextBox.Text = " = " + operator_click + "  " + tbInput.Text;
            }
        }

        private void NegateBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = tbInput.Text.Trim();

            if (DisplayTBinput == "0") return;

            if (!DisplayTBinput.StartsWith("-"))
            {
                tbInput.Text = "-" + DisplayTBinput;
            }
            else
            {
                tbInput.Text = DisplayTBinput.Substring(1); // Remove the negative sign
            }
        }

        private void ReciprocalBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = tbInput.Text.Trim();

            double.TryParse(DisplayTBinput, out double DFirstNumber);

            if (DFirstNumber == 0)
            {
                resultTextBox.Text = "Cannot Divide By Zero";
                return;
            }

            double reciprocal = 1 / DFirstNumber;
            resultTextBox.Text = $"1/({DFirstNumber}) = {reciprocal}";
            tbInput.Text = reciprocal.ToString();
            operator_click = ' ';
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = tbInput.Text.Trim();
            double.TryParse(DisplayTBinput, out DFirstNumber);

            resultTextBox.Text = $"sqr({DFirstNumber}) =";
            tbInput.Text = Math.Pow(DFirstNumber, 2).ToString();
            operator_click = ' ';
        }

        private void SqRootBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = tbInput.Text.Trim();
            double.TryParse(DisplayTBinput, out DFirstNumber);

            // Handle the square root for double input
            resultTextBox.Text = $"√({DFirstNumber}) =";
            tbInput.Text = Math.Sqrt((double)DFirstNumber).ToString();
            operator_click = ' ';
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (tbInput.Text.Length <= 14 && !tbInput.Text.Contains("."))
            {
                tbInput.Text += ".";
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            string DisplayTBinput = tbInput.Text.Trim();
            if (DisplayTBinput == "0") return;

            if (!string.IsNullOrEmpty(DisplayTBinput))
            {
                DisplayTBinput = DisplayTBinput.Substring(0, DisplayTBinput.Length - 1);
            }

            if (string.IsNullOrEmpty(DisplayTBinput))
            {
                DisplayTBinput = "0";
            }
            tbInput.Text = DisplayTBinput;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            tbInput.Text = "0";
            resultTextBox.Text = "";
        }
    }
}