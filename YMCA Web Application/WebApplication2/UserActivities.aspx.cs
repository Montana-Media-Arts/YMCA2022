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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery = "spGetActivities";
            DataSet myDataSet = new DataSet();
            //string MyQuery1 = "spGetActivities";
          //  DataSet myDataSet2 = new DataSet();

            SqlCommand myCommand = new SqlCommand(MyQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);
            myConnection.Close();
            GridView1.DataSource = myDataSet.Tables[0];
            GridView1.DataBind();
            //GridView2.DataSource = myDataSet2.Tables[0];
            //GridView2.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}