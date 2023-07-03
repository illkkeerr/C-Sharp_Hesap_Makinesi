using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class frmHesapMakinesi : Form
    {
        public frmHesapMakinesi()
        {
            InitializeComponent();

        }
        #region Numbers and Operators Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "1";
            else
                lblResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "2";
            else
                lblResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "3";
            else
                lblResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "4";
            else
                lblResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "5";
            else
                lblResult.Text += "5";
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "6";
            else
                lblResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "7";
            else
                lblResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "8";
            else
                lblResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "9";
            else
                lblResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "0";
            else
                lblResult.Text += "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "/";
            else
                lblResult.Text += "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "x";
            else
                lblResult.Text += "x";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "-";
            else
                lblResult.Text += "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = "+";
            else
                lblResult.Text += "+";
        }

        private void btnDot_Click_1(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
                lblResult.Text = ",";
            else
                lblResult.Text += ",";
        }
        #endregion


        private void btnCal_Click(object sender, EventArgs e)
        {

            try
            {
                string text = lblResult.Text;
                List<string> text1 = new List<string>();
                string text2 = "";
                string[] numbers;
                List<string> Operators = new List<string>();
                List<string> MathOp = new List<string>();
                double result = 0;
                int index = 0;


                if (text[0] == '+' || text[0] == '-')
                    text = '0' + text;

                for (int i = 0; i < text.Length; i++)
                {
                    text1.Add(text[i].ToString());
                    if (text[i] == '-' && text[i - 1] == '-')
                    {
                        text1.RemoveAt(i-1);
                        text1.RemoveAt(i-1);
                        text1.Add("+");
                        text1.Add("+");
                    }
                }


                for (int i = 0; i < text1.Count; i++)
                {
                    text2 += text1[i];
                    if (text1[i] == "+" || text1[i] == "-")
                    {
                        text2 += '0';
                    }
                }





                for (int i = 0; i < text2.Length; i++)
                {
                    if (text2[i] == '+' || text2[i] == '-' || text2[i] == 'x' || text2[i] == '/')
                        Operators.Add(text2[i].ToString());
                }

                numbers = text2.Split(new char[] { '+', '-', '/', 'x' });

                for (int i = 0; i < numbers.Length; i++)
                {
                    MathOp.Add(numbers[i]);

                    if (i < numbers.Length - 1)
                        MathOp.Add(Operators[i]);
                }
                for (int i = 0; i < MathOp.Count; i++)
                {
                    if (MathOp[i] == "")
                        MathOp.RemoveAt(i);
                }

            Bolme:

                if (MathOp.Contains("/"))
                {
                    index = MathOp.IndexOf("/");

                    if (MathOp[index + 1] == "+")
                    {
                        MathOp[index + 2] = "+" + MathOp[index + 2];
                        MathOp.RemoveAt(index + 1);
                    }
                    else if (MathOp[index + 1] == "-")
                    {
                        MathOp[index + 2] = "-" + MathOp[index + 2];
                        MathOp.RemoveAt(index + 1);
                    }
                    if (MathOp[index + 1] == "-00" || MathOp[index + 1] == "+00" || MathOp[index + 1] == "0")
                    {
                        lblResult.Text = "Error";
                        goto Result;
                    }


                    result = double.Parse(MathOp[index - 1]) / double.Parse(MathOp[index + 1]);
                    MathOp[index - 1] = (double.Parse(MathOp[index - 1]) / double.Parse(MathOp[index + 1])).ToString();
                    MathOp.RemoveAt(index);
                    MathOp.RemoveAt(index);
                    goto Bolme;
                }
            Carpma:
                if (MathOp.Contains("x"))
                {
                    index = MathOp.IndexOf("x");
                    if (MathOp[index + 1] == "+")
                    {
                        MathOp[index + 2] = "+" + MathOp[index + 2];
                        MathOp.RemoveAt(index + 1);
                    }
                    else if (MathOp[index + 1] == "-")
                    {
                        MathOp[index + 2] = "-" + MathOp[index + 2];
                        MathOp.RemoveAt(index + 1);
                    }
                    if (MathOp[index + 1] == "-0" || MathOp[index + 1] == "+0")
                    {
                        lblResult.Text = "Error";
                        goto Result;
                    }
                    if (MathOp[index + 1] == "+")
                    {
                        MathOp[index + 2] = "+" + MathOp[index + 2];
                        MathOp.RemoveAt(index + 1);
                    }
                    else if (MathOp[index + 1] == "-")
                    {
                        MathOp[index + 2] = "-" + MathOp[index + 2];
                        MathOp.RemoveAt(index + 1);
                    }
                    result = double.Parse(MathOp[index - 1]) * double.Parse(MathOp[index + 1]);
                    MathOp[index - 1] = (double.Parse(MathOp[index - 1]) * double.Parse(MathOp[index + 1])).ToString();
                    MathOp.RemoveAt(index);
                    MathOp.RemoveAt(index);
                    goto Carpma;
                }
            Toplama:
                if (MathOp.Contains("+"))
                {
                    index = MathOp.IndexOf("+");
                    result = double.Parse(MathOp[index - 1]) + double.Parse(MathOp[index + 1]);
                    MathOp[index - 1] = (double.Parse(MathOp[index - 1]) + double.Parse(MathOp[index + 1])).ToString();
                    MathOp.RemoveAt(index);
                    MathOp.RemoveAt(index);
                    goto Toplama;
                }
            Cikarma:
                if (MathOp.Contains("-"))
                {
                    index = MathOp.IndexOf("-");
                    result = double.Parse(MathOp[index - 1]) - double.Parse(MathOp[index + 1]);
                    MathOp[index - 1] = (double.Parse(MathOp[index - 1]) - double.Parse(MathOp[index + 1])).ToString();
                    MathOp.RemoveAt(index);
                    MathOp.RemoveAt(index);
                    goto Cikarma;
                }

                MathOp[0] = Math.Round(double.Parse(MathOp[0]), 3).ToString();

                lblOperationText.Text = lblResult.Text + "=";
                lblResult.Text = MathOp[0].ToString();
            //lblResult.Text = result.ToString();
            Result:

                GC.Collect();

            }
            catch
            {
                lblResult.Text = "Error";
            }

        }
        private void btnRoot_Click(object sender, EventArgs e)
        {
            btnCal_Click(sender, e);
            lblResult.Text = Math.Round(Math.Pow(double.Parse(lblResult.Text), 0.5),3).ToString();

        }

        private void frmHesapMakinesi_Load(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            lblOperationText.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int son = lblResult.Text.Length - 1;
            if (son > -1)
                lblResult.Text = lblResult.Text.Remove(son);
            if (lblResult.Text == "")
                lblResult.Text = "0";

            GC.Collect();
        }


    }

}
