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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string pwd = TextBox2.Text;
            DataSet myDataSet = new DataSet();
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery = "spUserVerification";
            
            SqlCommand myCommand = new SqlCommand(MyQuery);
            SqlParameter[] myParameters = new SqlParameter[2];
            myParameters[0] = new SqlParameter("username", username);
            myParameters[1] = new SqlParameter("pwd", pwd);
            myCommand.Parameters.AddRange(myParameters);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);
            myConnection.Close();

            if (myDataSet.Tables[0].Rows.Count > 0)
            {
                Response.Write("You are logged in");
                Response.Redirect("Admin.aspx");
            }
            else 
                    {
                Response.Redirect("CreateUser.aspx");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}