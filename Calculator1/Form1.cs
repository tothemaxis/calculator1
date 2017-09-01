using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        long[] plusArray = new long[2];
        long[] minusArray = new long[2];
        long[] mulArray = new long[2];
        long[] divArray = new long[2];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0
                && (!textBox1.Text.EndsWith("+"))
                && (!textBox1.Text.EndsWith("-"))
                && (!textBox1.Text.EndsWith("*"))
                && (!textBox1.Text.EndsWith("/")))
            {
                textBox1.Text += btn_0.Text;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_1.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_9.Text;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "+"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "-"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "*"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "/")
            {
                if (textBox1.Text.Contains("+") == false
                    && textBox1.Text.Contains("*") == false
                    && textBox1.Text.Contains("/") == false)
                {
                    textBox1.Text += btn_plus.Text;
                    plusArray[0] = Convert.ToInt64(textBox1.Text.Substring(0, textBox1.TextLength - 1));
                }
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "+"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "-"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "*"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "/")
            {
                textBox1.Text += btn_minus.Text;
                //minusArray[0] = Convert.ToInt64(textBox1.Text.Substring(0, textBox1.TextLength - 1));
            }
            else if (textBox1.TextLength == 0 )
            {
                textBox1.Text += btn_minus.Text;
            }
            else if (textBox1.Text.Substring(textBox1.TextLength - 1, 1) == "-")
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
                textBox1.Text += btn_plus.Text;
                minusArray[0] = Convert.ToInt64(textBox1.Text.Substring(0, textBox1.TextLength - 1));
            }

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "+"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "-"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "*"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "/")
            {
                if (textBox1.Text.Contains("*") == false
                    && textBox1.Text.Contains("+") == false
                    && textBox1.Text.Contains("/") == false)
                {
                    textBox1.Text += btn_multiply.Text;
                    mulArray[0] = Convert.ToInt64(textBox1.Text.Substring(0, textBox1.TextLength - 1));
                }
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "+"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "-"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "*"
                && textBox1.Text.Substring(textBox1.TextLength - 1, 1) != "/")
            {
                if (textBox1.Text.Contains("/") == false
                    && textBox1.Text.Contains("+") == false
                    && textBox1.Text.Contains("*") == false)
                {
                    textBox1.Text += btn_divide.Text;
                    divArray[0] = Convert.ToInt64(textBox1.Text.Substring(0, textBox1.TextLength - 1));
                }
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            int count = textBox1.Text.Count(minusSign => minusSign == '-');

            //if press equal and have operators, delete it
            if (textBox1.Text.EndsWith("+")
                || textBox1.Text.EndsWith("-")
                || textBox1.Text.EndsWith("*")
                || textBox1.Text.EndsWith("/"))
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
            else
            //plus
            if (textBox1.Text.Contains("+"))
            {
                var secondValue = textBox1.Text.Substring(textBox1.Text.LastIndexOf('+') + 1);
                plusArray[1] = Convert.ToInt64(secondValue);
                textBox1.Clear();

                double sum = plusArray[0] + plusArray[1];
                textBox1.Text += sum.ToString();
            }
            //minus

            if (count >= 1)
            {
                var secondValue = textBox1.Text.Substring(textBox1.Text.LastIndexOf('-') + 1);
                minusArray[1] = Convert.ToInt64(secondValue);
                textBox1.Clear();
                double minus = minusArray[0] - minusArray[1];
                textBox1.Text += minus.ToString();
            }
            //multiply
            if (textBox1.Text.Contains("*"))
            {
                var secondValue = textBox1.Text.Substring(textBox1.Text.LastIndexOf('*') + 1);
                mulArray[1] = Convert.ToInt64(secondValue);
                textBox1.Clear();

                double multiply = mulArray[0] * mulArray[1];
                textBox1.Text += multiply.ToString();
                
            }
            //division
            if (textBox1.Text.Contains("/"))
            {
                var secondValue = textBox1.Text.Substring(textBox1.Text.LastIndexOf('/') + 1);
                divArray[1] = Convert.ToInt64(secondValue);
                textBox1.Clear();

                double divide = divArray[0] / divArray[1];
                textBox1.Text += divide.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
