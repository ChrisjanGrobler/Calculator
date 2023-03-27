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

        public float num1;
        public float num2;
        public string num;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e) //button 0
        {
            lblDisplay.Text += "0";
        }


        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "/";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "x";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            num = lblDisplay.Text;
            num = num.Substring(0,1);

            if (num == "+" || num == "-" || num == "x" || num == "/")
            {
                num1 = float.Parse(lblDisplay.Text.Remove(0, 1));
                ContinueCalc(num1,"+");
            }
            else
            {
            num1 = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "+";   
            }

  
        }
        
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calc(num1);
        }
        
        private void gbCalc_Enter(object sender, EventArgs e)
        {

        }



        Values val = new Values();

        public void ContinueCalc(float num1, string type)
        {

        }

        public void Calc(float num1)
        {
            val._num1 = num1;
            string NumType = lblDisplay.Text;
            string type = NumType.Substring(0,1);
            NumType = NumType.Remove(0,1);
            val._num2= float.Parse(NumType);

            float result = 0;

            switch (type)
            {

                case "/":
                            result = val._num1 / val._num2;
                    break;
                case "x":
                    result = val._num1 * val._num2;
                    break;
                case "-":
                    result = val._num1 - val._num2;
                    break;
                case "+":
                    result = val._num1 + val._num2;
                    break;

                default:
                    lblDisplay.Text = "Error";
                    break;
            }

            lblDisplay.Text = result.ToString();
            num1 = result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            num = "";
            lblDisplay.Text = "";
        }
    }
}
