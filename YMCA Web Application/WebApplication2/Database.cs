using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public class Database
    {

        private SqlConnection openDatabase()
        {
            string myConnectionString =
               ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            
            SqlConnection myConnection;

            myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();

            return myConnection;
        }

        private void closeDatabase(SqlConnection myConnection)
        {
            myConnection.Close();
        }

        public DataSet getQueryWithoutParameters(string query)
        {
            string myQuery = query;
            SqlConnection myConnection = openDatabase();
            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(myQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);

            closeDatabase(myConnection);

            return myDataSet;
        }


        public DataSet getQueryWithParameters(string query, SqlParameter[] parameters)
        {
            string myQuery = query;
            SqlConnection myConnection = openDatabase();
            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(myQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddRange(parameters);

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);

            closeDatabase(myConnection);

            return myDataSet;
        }
        public void RunQueryWithParameters(string query, SqlParameter[] parameters)
        {
            string myQuery = query;
            SqlConnection myConnection = openDatabase();
            
            SqlCommand myCommand = new SqlCommand(myQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddRange(parameters);
            myCommand.ExecuteNonQuery();
            

            closeDatabase(myConnection);

           
        }

    }
}