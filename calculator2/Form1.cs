using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        double[] firstArray = new double[1];
        double[] plusArray = new double[2];
        double[] minusArray = new double[2];
        double[] mulArray = new double[2];
        double[] divArray = new double[2];
        double[] modArray = new double[2];
        double[] yArray = new double[2];
        double[] expoArray = new double[2];
        double[] memoArray = new double[2];
        int operation;
        double ans;


        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_2.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_1.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && ans !=0)
            {
                textBox1.Text += btn_0.Text;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ans == 0)
            {
                textBox1.Clear();
            }
            textBox1.Text += btn_9.Text;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += btn_dot.Text;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            //CE Button
            textBox1.Clear();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                // plus sign = 1
                operation = 1;
            }
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                textBox1.Text += minus_btn.Text;
            }
            else if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                // minus sign = 2
                operation = 2;
            }
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                // multiply sign = 3
                operation = 3;
            }
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                // divide sign = 4
                operation = 4;
            }
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")
                && operation != 0))
            {
                compute(operation);
            }
        }
        public void compute(int operation)
        {
            switch (operation)
            {
                //plus
                case 1:
                    plusArray[0] = Convert.ToDouble(textBox1.Text);
                    ans = firstArray[0] + plusArray[0];
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + " + " + plusArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                //minus
                case 2:
                    minusArray[0] = Convert.ToDouble(textBox1.Text);
                    ans = (firstArray[0]) - (minusArray[0]);
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + " - " + minusArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                //multiply
                case 3:
                    mulArray[0] = Convert.ToDouble(textBox1.Text);
                    ans = firstArray[0] * mulArray[0];
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + " x " + mulArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                //divide
                case 4:
                    divArray[0] = Convert.ToDouble(textBox1.Text);
                    ans = (firstArray[0]) / (divArray[0]);
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + " / " + divArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                //mod
                case 5:
                    modArray[0] = Convert.ToDouble(textBox1.Text);
                    ans = firstArray[0] % modArray[0];
                    textBox1.Clear();
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + " Mod " + modArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                //Y for X tothe Y
                case 6:
                    yArray[0] = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    ans = Math.Pow(firstArray[0], yArray[0]);
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + "^" + yArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                case 7:
                    expoArray[0] = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    ans = (firstArray[0] * Math.Pow(10, expoArray[0]));
                    textBox1.Text = ans.ToString();
                    History_richbox.Text += firstArray[0] + ".e +" + expoArray[0] + " = " + ans + "\n";
                    //if press equal again
                    firstArray[0] = ans;
                    break;
                default:
                    break;

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //mod button
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-"))
                && (!textBox1.Text.Contains("mod")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                // mod sign = 5
                operation = 5;
            }
        }

        private void btn_Xtothe2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Math.Pow(firstArray[0], 2).ToString();
                History_richbox.Text += firstArray[0] + "^2 = " + textBox1.Text + "\n";
            }
        }

        private void btn_Xtothe3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Math.Pow(firstArray[0], 3).ToString();
                History_richbox.Text += firstArray[0] + "^3 = " + textBox1.Text + "\n";
            }
        }

        private void btn_10totheX_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Math.Pow(10, firstArray[0]).ToString();
                History_richbox.Text += "10^" + firstArray[0] + " = " + textBox1.Text + "\n";
            }
        }

        private void btn_XtotheY_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = 6;
            }
        }

        private void clearE_btn_Click(object sender, EventArgs e)
        {
            //clear all button actually.
            textBox1.Clear();
            operation = 0;
            firstArray[0] = 0;
            plusArray[0] = 0;
            plusArray[1] = 0;
            minusArray[0] = 0;
            minusArray[1] = 0;
            divArray[0] = 0;
            divArray[1] = 0;
            mulArray[0] = 0;
            mulArray[1] = 0;
            modArray[0] = 0;
            modArray[1] = 0;
            yArray[0] = 0;
            yArray[1] = 0;
            expoArray[0] = 0;
            expoArray[1] = 0;
            History_richbox.Clear();
            memo_richtext.Clear();
            memoArray[0] = 0;
            memoArray[1] = 0;

        }

        private void btn_expo_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                firstArray[0] = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = 7;
            }
        }

        private void History_richbox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btn_Mminus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                memoArray[0] = Convert.ToDouble(textBox1.Text);
                memoArray[1] -= memoArray[0];
                memo_richtext.Text += memoArray[1].ToString() + "\n";
            }
        }

        private void btn_Mplus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-")))
            {
                memoArray[0] = Convert.ToDouble(textBox1.Text);
                memoArray[1] += memoArray[0];
                memo_richtext.Text += memoArray[1].ToString() + "\n";
            }
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            memo_richtext.Clear();
            memoArray[0] = 0;
            memoArray[1] = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (!textBox1.Text.EndsWith("-"))
                && (!textBox1.Text.StartsWith("-")))
            {
                // n! button (factorial)
                double factorNum = Convert.ToDouble(textBox1.Text);
                double sumfact = factorNum;
                for (int i = 1; i < factorNum; i++)
                {
                    sumfact *= i;
                }
                textBox1.Clear();
                textBox1.Text = sumfact.ToString();
                History_richbox.Text += "factor(" + factorNum.ToString() + ") = " + textBox1.Text + "\n";
            }
            else
                textBox1.Clear();
            textBox1.Text += "invalid input";
            History_richbox.Text += "invalid input";
        }

        private void convertBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binaryConvert form2 = new binaryConvert();
            form2.Show();
        }
    }
}
