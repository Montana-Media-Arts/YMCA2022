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
            Database myData = new Database();
           
            string MyQuery = "spGetUsers";
            DataSet myDataSet = myData.getQueryWithoutParameters(MyQuery);
            

            GridView1.DataSource = myDataSet.Tables[0];
            GridView1.DataBind();
            string MyQuery2 = "spGetTotalTime";
            DataSet myDataSet2 = myData.getQueryWithoutParameters(MyQuery2);


            GridView2.DataSource = myDataSet2.Tables[0];
            GridView2.DataBind();

            int totalTime;
            totalTime = 0;
            for (int I = 0; I < myDataSet2.Tables[0].Rows.Count; I++)
            {
                totalTime = totalTime + Convert.ToInt32(myDataSet2.Tables[0].Rows[I]["timeDifference"]);
            }
            Label3.Text =Convert.ToString (totalTime);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;
            String dob = TextBox3.Text;
            String userID = TextBox4.Text;
            Database myData = new Database();
           
            string MyQuery = "spUpdateUser";
            
           
            SqlParameter[] myParameters = new SqlParameter[4];
            myParameters[0] = new SqlParameter("username", userName);
            myParameters[1] = new SqlParameter("pwd", password);
            myParameters[2] = new SqlParameter("dob", dob);
            myParameters[3] = new SqlParameter("userID", userID);
            myData.RunQueryWithParameters(MyQuery,myParameters);

            Response.Write("User Updated");
            //Response.Redirect("WebForm4.aspx?userName=" + userName);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String userID = TextBox4.Text;
            Database myData = new Database();
            string MyQuery2 = "spDeleteUsers";
            
            
           
            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("userid",userID);

            myData.RunQueryWithParameters(MyQuery2, myParameters);
            Response.Write("User Deleted");
            //Response.Redirect("WebForm4.aspx?userName=" + userID);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogOut.aspx");
        }

        
    }
}