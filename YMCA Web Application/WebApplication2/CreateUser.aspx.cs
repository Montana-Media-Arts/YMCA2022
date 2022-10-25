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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;
            String dob = TextBox3.Text;
            if( userName != "")
            {
                string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                string MyQuery = "spUserRegister";
                DataSet myDataSet = new DataSet();
                SqlCommand myCommand = new SqlCommand(MyQuery);
                SqlParameter[] myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("username", userName);
                myCommand.Parameters.AddRange(myParameters);
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(myDataSet);
                if (myDataSet.Tables[0].Rows.Count > 0)
                {
                    Response.Write("<script>window.alert('User already exists');</script>");
                }
                else
                {
                    MyQuery = "spInsertNewUser";
                    Response.Write(MyQuery);
                    myCommand = new SqlCommand(MyQuery);
                    myParameters = new SqlParameter[3];
                    myParameters[0] = new SqlParameter("username", userName);
                    myParameters[1] = new SqlParameter("pwd", password);
                    myParameters[2] = new SqlParameter("dateOfBirth", dob);
                    myCommand.Parameters.AddRange(myParameters);
                    myCommand.Connection = myConnection;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.ExecuteNonQuery();
                    Response.Redirect("Admin.aspx?userName=" + userName);

                }
               
                }
               

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}