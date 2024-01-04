using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_WinForm_
{
    public partial class Form1 : Form
    {
        double? value;
        double? result;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Numbers
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        #endregion

        #region Clear
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            value = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove((textBox1.Text.Length - 1), 1);
        }
        #endregion

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "bolme";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "vurma";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "cixma";
            value = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = "-";
            Operation(value, operation);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = "+";
            Operation(value, operation);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = value.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            value = -value;
        }

        public void Operation(double? value, string operation)
        {
            string LastOperation = label1.Text;
            double currentValue;
            if (Double.TryParse(label2.Text, out currentValue))
            {
                if (result == null)
                {
                    result = value;
                }
                else
                {
                    if (LastOperation == "+")
                        result = (double)(result + value);
                    else if (LastOperation == "-")
                        result = (double)(result - value);
                    else if (LastOperation == "*")
                        result = (double)(result * value);
                    else if (LastOperation == "/")
                    {
                        if (value != 0)
                            result = (double)(result / value);
                        else
                        {
                            // Handle division by zero
                            label2.Text = "Error";
                            return;
                        }
                    }
                }
                label2.Text = result.ToString();
                label1.Text = operation;
            }
            else
            {
                // Handle parsing error
                label2.Text = "Error";
            }
        }
        //public void Opreation(double? value, string operation)
        //{
        //    double currentValue;
        //    string LastOperation = label1.Text;
        //    if (Double.TryParse(label2.Text, out currentValue))
        //    {
        //        if (result == null)
        //        {
        //            result = (double)value;
        //        }
        //        else
        //        {
        //            if (LastOperation == "+")
        //                result = (double)(result + value);
        //            else if (LastOperation == "-")
        //                result = (double)(result - value);
        //            else if (LastOperation == "*")
        //                result = (double)(result * value);
        //            else if (LastOperation == "/")
        //                result = (double)(result / value);
        //        }
        //        label2.Text = result.ToString();
        //        label1.Text = operation;
        //    }
        //    else
        //    {
        //        textBox1.Text = "Error";
        //    }
        //}
    }
}
