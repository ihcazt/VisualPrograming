using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09_SimpleCalculator
{
    public partial class SimpleCalculatorForm : Form
    {
        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }

        private int firstValue = 0;
        private int secondValue = 0;
        private int? result = 0;

        private void SimpleCalculator_Load(object sender, EventArgs e)
        {
            FirstValueTextBox.Text = firstValue.ToString();
            SecondValueTextBox.Text = secondValue.ToString();
            ResultTtextBox.Text = result.ToString();
            OperatorComboBox.SelectedIndex = 0;
        }

        private void FirstValueTextBox_Leave(object sender, EventArgs e)
        {
            if(int.TryParse(FirstValueTextBox.Text, out int value))
            {
                firstValue = value;
            }
            else
            {
                FirstValueTextBox.Text = "0";
                firstValue = 0;
            }

            Calc();
        }

        private void SecondValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(SecondValueTextBox.Text, out int value))
            {
                secondValue = value;
            }
            else
            {
                SecondValueTextBox.Text = "0";
                secondValue = 0;
            }
            Calc();
        }

        private void OperatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Calc()
        {
            switch (OperatorComboBox.Text)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if (secondValue != 0)
                    {
                        result = firstValue / secondValue;
                    }
                    else
                    {
                        result = null;
                    }
                    break;
            }

            if (result != null)
            {
                ResultTtextBox.Text = result.ToString();
            }
            else
            {
                ResultTtextBox.Text = "NaN";
            }
        }
    }
}
