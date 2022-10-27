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
            Database myData = new Database();
          
            string MyQuery = "spUserVerification";
          
            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("username", username);
           
            DataSet myDataSet = myData.getQueryWithParameters(MyQuery, myParameters);
           
            if (myDataSet.Tables[0].Rows.Count > 0)
            {
                int userID = Convert.ToInt32(myDataSet.Tables[0].Rows[0]["userID"]);
                string MyQuery2 = "spInsertLogInTime";
                 myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("userID", userID);
                myData.RunQueryWithParameters(MyQuery2,myParameters);
                Response.Write("You are logged in");
                Response.Redirect("https://montana-media-arts.github.io/YMCA2022/AidansP5Experiences/index.html");
            }
            else 
                    {
                Response.Write("Please Log In");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}