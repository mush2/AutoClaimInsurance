using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectivity
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con1 = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con1.ConnectionString = "Data Source=CGI-JAVA-116\\CGI;Initial Catalog = abu;Integrated Security = true"; ;
            con1.Open();
            SqlCommand cmd = new SqlCommand("select & from employees where empId=@empID", con1);
            SqlParameter param1 = cmd.Parameters.Add("@empId", SqlDbType.VarChar, 15);
            param1.Value = TextBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}