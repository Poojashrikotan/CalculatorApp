using Caculator.Classses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caculator
{
    public partial class History : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GAN35H38;Initial Catalog=CalculatorB\\DB;User Id=sa;password=pctadmin$123");
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDetails();
        }
        public void BindDetails()
        {
            List<Calcu> list = new List<Calcu>();
            list = GetDetails();
            gvDetails.DataSource = list;
            gvDetails.DataBind();

        }
        private List<Calcu> GetDetails()
        {
            con.Open();
            SqlDataReader sdr = null;
            List<Calcu> list = new List<Calcu>();
            string query = null;
            try
            {
                //string midd = mID.ToString();
                query = "select * from calci";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@MachineID", mID);
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Calcu newone = new Calcu();
                        newone.num1 = sdr["num1"].ToString();
                        newone.num2 = sdr["num2"].ToString();
                        newone.opt = sdr["Operation"].ToString();
                        newone.res = sdr["res"].ToString();
                        newone.ondate = sdr["createdOn"].ToString();
                        list.Add(newone);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return list;
        }
    }
}