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
           
            string MyQuery = "spGetActivities";
            Database myData = new Database();
            DataSet dataSet = myData.getQueryWithoutParameters(MyQuery);

            GridView1.DataSource = dataSet.Tables[0];
            GridView1.DataBind();


            // HttpCookie myCookie = Request.Cookies["userinfo"];
            // String userName = Request.QueryString["userName"];
            //String password = Session["secret"].ToString();
            // message3.Text = password;
            //lblMessage.Text = userName;
            //message2.Text = myCookie.Value;
            //Response.Write(messageFromQueryString);
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox3.Text;
            Database myData = new Database();

            string MyQuery = "spUserVerification";

            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("username", username);

            DataSet myDataSet = myData.getQueryWithParameters(MyQuery, myParameters);
            if(myDataSet.Tables[0].Rows.Count > 0)
            {
                int userID = Convert.ToInt32(myDataSet.Tables[0].Rows[0]["userID"]);
                string MyQuery2 = "spInsertLogOutTime";
                myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("userID", userID);
                myData.RunQueryWithParameters(MyQuery2, myParameters);
                Response.Redirect("https://montana-media-arts.github.io/YMCA2022/AidansP5Experiences/index2.html");
            }
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}