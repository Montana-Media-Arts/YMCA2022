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
    public partial class WebForm2 : System.Web.UI.Page
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
            myCommand.CommandType = CommandType.StoredProcedure ;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);
            myConnection.Close();

            
            // HttpCookie myCookie = Request.Cookies["userinfo"];
            // String userName = Request.QueryString["userName"];
            //String password = Session["secret"].ToString();
            // message3.Text = password;
            //lblMessage.Text = userName;
            //message2.Text = myCookie.Value;
            //Response.Write(messageFromQueryString);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}