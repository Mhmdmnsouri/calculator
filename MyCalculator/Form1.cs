using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Frm1 : Form
    {
        ICalculator calculator;
        public Frm1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        bool ValidateInputs()
        {
            bool IsValid = true;
            if (Numric1.Value == 0)
            {
                IsValid = false;
                MessageBox.Show("Please enter your first number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Numric2.Value == 0)
                {
                    IsValid = false;
                    MessageBox.Show("Please enter your second number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return IsValid;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int plusSum = calculator.plus((int)Numric1.Value, (int)Numric2.Value);
                MessageBox.Show($"Sum is : {plusSum}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minusSum = calculator.minus((int)Numric1.Value, (int)Numric2.Value);
                MessageBox.Show($"Sum is : {minusSum}","Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multipleSum = calculator.multiple((int)Numric1.Value, (int)Numric2.Value);
                MessageBox.Show($"Sum is : {multipleSum}","Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divideSum = calculator.divide((int)Numric1.Value, (int)Numric2.Value);
                MessageBox.Show($"Sum is : {divideSum}","Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
