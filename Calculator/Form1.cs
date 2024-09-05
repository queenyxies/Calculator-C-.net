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

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void SetOperation(string op)
        {
            if (int.TryParse(txtTotal.Text, out num1))
            {
                option = op;
                txtTotal.Clear();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a number.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotal.Text, out num2))
            {
                switch (option)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                }
                txtTotal.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a number.");
            }
        }
    }
}
