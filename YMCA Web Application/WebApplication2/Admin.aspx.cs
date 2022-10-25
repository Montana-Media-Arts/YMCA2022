using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery = "spGetUsers";
            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(MyQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);
            myConnection.Close();

            GridView1.DataSource = myDataSet.Tables[0];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;
            String dob = TextBox3.Text;
            String userID = TextBox4.Text;
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery = "spUpdateUser";
            Response.Write(MyQuery);
            SqlCommand myCommand = new SqlCommand(MyQuery);
            SqlParameter[] myParameters = new SqlParameter[4];
            myParameters[0] = new SqlParameter("username", userName);
            myParameters[1] = new SqlParameter("pwd", password);
            myParameters[2] = new SqlParameter("dob", dob);
            myParameters[3] = new SqlParameter("userID", userID);
            myCommand.Parameters.AddRange(myParameters);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.ExecuteNonQuery();

            Response.Write("User Updated");
            //Response.Redirect("WebForm4.aspx?userName=" + userName);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String userID = TextBox4.Text;
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery2 = "spDeleteUsers";
            Response.Write(MyQuery2);
            
            SqlCommand myCommand = new SqlCommand(MyQuery2);
            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("userid",userID);

            myCommand.Parameters.AddRange(myParameters);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.ExecuteNonQuery();
            Response.Write("User Deleted");
            //Response.Redirect("WebForm4.aspx?userName=" + userID);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogOut.aspx");
        }
    }
}