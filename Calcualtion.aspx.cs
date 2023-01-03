using Caculator.Classses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caculator
{
    public partial class Calcualtion : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GAN35H38;Initial Catalog=CalculatorB\\DB;User Id=sa;password=pctadmin$123");
        static float a, c, d;
        static char b;
        protected void Page_Load(object sender, EventArgs e)
        {
         //   txtnumber.Text = "";
        }

        internal  string InsertDetals(Calcu inputtext)
        {
            con.Open();
            SqlDataReader sdr = null;
            string sucess = "";
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Calci values(@num1,@num2,@opt,@res,@ondate)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@num1", inputtext.num1);
                cmd.Parameters.AddWithValue("@num2", inputtext.num2);
                cmd.Parameters.AddWithValue("@opt", inputtext.opt);
                cmd.Parameters.AddWithValue("@res", inputtext.res);
                cmd.Parameters.AddWithValue("@ondate", inputtext.ondate);               
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        sucess = "Inserted";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("InsertDetails" + ex.Message);
              
            }
            finally
            {
                if (con != null) con.Close();
            }
            return sucess;
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

        public void btneql_Click(object sender, EventArgs e)
        {
            try
            {
                Calcu calcus = new Calcu();
                calcus.num2= txtnumber.Text;
                
                c = Convert.ToInt32(txtnumber.Text);
                txtnumber.Text = "";
                if (b == '/')
                {
                    calcus.num1 = a.ToString();
                    calcus.opt = "Division";
                    d = a / c;
                    txtnumber.Text += d;
                    a = d;
                    calcus.res = a.ToString();
                }
                else if (b == '+')
                {
                    calcus.num1 = a.ToString();
                    calcus.opt = "Addition";
                    d = a + c;
                    txtnumber.Text += d;
                    a = d;
                    calcus.res = a.ToString();
                }
                else if (b == '-')
                {
                    calcus.num1 = a.ToString();
                    calcus.opt = "Subtraction";
                    d = a - c;
                    txtnumber.Text += d;
                    a = d;
                    calcus.res = a.ToString();
                }
                else
                {
                    calcus.num1 = a.ToString();
                    calcus.opt = "Multiplication";
                    d = a * c;
                    txtnumber.Text += d;
                    a = d;
                    calcus.res = a.ToString();
                }
               calcus.ondate= DateTime.Now.ToString(); ;



             //   List<Calcu> list=new List<Calcu>();
                string success = InsertDetals(calcus);

            }
            catch (Exception ex)
            {
                Console.Write("btneql_Click" + ex.Message);
            }

        }

    }
}