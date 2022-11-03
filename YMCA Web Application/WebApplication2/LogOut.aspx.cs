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
            if (!Page.IsPostBack)
            {
                string MyQuery = "spGetActivities";
                Database myData = new Database();
                DataSet dataSet = myData.getQueryWithoutParameters(MyQuery);

                GridView2.DataSource = dataSet.Tables[0];
                GridView2.DataBind();
            }


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
                GoThroughTable(userID);
                Response.Redirect("https://montana-media-arts.github.io/YMCA2022/AidansP5Experiences/index2.html");
            }
           
        }
        private void GoThroughTable(int userID)
        {
            foreach (GridViewRow gvrow in GridView2.Rows)
            {
                var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                if (checkbox.Checked)
                {
                    Label lblActivityID = gvrow.FindControl("Label1") as Label;
                    Label lblActivityName = gvrow.FindControl("Label2") as Label;
                    TextBox lblTimeSpent = gvrow.FindControl("TextBox1") as TextBox;

                    int ActivityID = Convert.ToInt32(lblActivityID.Text);
                    int TimeSpent = Convert.ToInt32(lblTimeSpent.Text);

                    string MyQuery = "spInsertUserActivityTime";
                    Database myData = new Database();
                    SqlParameter[] myParameters = new SqlParameter[3];
                    myParameters[0] = new SqlParameter("userID", userID);
                    myParameters[1] = new SqlParameter("activityID", ActivityID);
                    myParameters[2] = new SqlParameter("timeSpent", TimeSpent);

                    myData.RunQueryWithParameters(MyQuery, myParameters);

                
                }
            }
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}