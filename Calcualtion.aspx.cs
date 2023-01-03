using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caculator
{
    public partial class Calcualtion : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;
        protected void Page_Load(object sender, EventArgs e)
        {
         //   txtnumber.Text = "";
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn1.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn1.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn1_Click" + ex.Message);
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn2.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn2.Text;

            }
             catch (Exception ex)
            {
                Console.Write("btn2_Click" + ex.Message);
            }
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn3.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn3.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn3_Click" + ex.Message);
            }
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn4.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn4.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn4_Click" + ex.Message);
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn5.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn5.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn5_Click" + ex.Message);
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn6.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn6.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn6_Click" + ex.Message);
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn7.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn7.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn7_Click" + ex.Message);
            }
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn8.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn8.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn8_Click" + ex.Message);
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn9.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn9.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn9_Click" + ex.Message);
            }
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnumber.Text == "+") || (txtnumber.Text == "-") || (txtnumber.Text == "*") || (txtnumber.Text == "/"))
                {
                    txtnumber.Text = "";
                    txtnumber.Text = txtnumber.Text + btn0.Text;
                }
                else
                    txtnumber.Text = txtnumber.Text + btn0.Text;

            }
            catch (Exception ex)
            {
                Console.Write("btn0_Click" + ex.Message);
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
               // var bb = txtnumber.Text;
                a = Convert.ToInt32(txtnumber.Text);
                txtnumber.Text = "";
                b = '+';
                txtnumber.Text += b;
            }
            catch (Exception ex)
            {
                Console.Write("btnadd_Click" + ex.Message);
            }
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(txtnumber.Text);
                txtnumber.Text = "";
                b = '-'; 
                txtnumber.Text += b;
            }
            catch (Exception ex)
            {
                Console.Write("sub_Click" + ex.Message);
            }

        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(txtnumber.Text);
                txtnumber.Text = "";
                b = '*';
                txtnumber.Text += b;
            }
            catch (Exception ex)
            {
                Console.Write("sub_Click" + ex.Message);
            }
        }
        protected void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(txtnumber.Text);
                txtnumber.Text = "";
                b = '/';
                txtnumber.Text += b;
            }
            catch (Exception ex)
            {
                Console.Write("sub_Click" + ex.Message);
            }
        }

        protected void btnclr_Click(object sender, EventArgs e)
        {
            try
            {
                txtnumber.Text = "";
            }
            catch (Exception ex)
            {
                Console.Write("btnclr_Click" + ex.Message);
            }
        }

        protected void btneql_Click(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToInt32(txtnumber.Text);
                txtnumber.Text = "";
                if (b == '/')
                {
                    d = a / c;
                    txtnumber.Text += d;
                    a = d;
                }
                else if (b == '+')
                {
                    d = a + c;
                    txtnumber.Text += d;
                    a = d;
                }
                else if (b == '-')
                {
                    d = a - c;
                    txtnumber.Text += d;
                    a = d;
                }
                else
                {
                    d = a * c;
                    txtnumber.Text += d;
                    a = d;
                }
            }
            catch (Exception ex)
            {
                Console.Write("sub_Click" + ex.Message);
            }

        }

      
    }
}