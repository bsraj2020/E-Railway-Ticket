using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace E_Ticket_Pro_472
{
    class DBAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        // private static SqlDataReader reader = new SqlDataReader();
        private static string connStr = "Data Source=(local); Initial Catalog= E_Ticket_DB ; Integrated Security=True; ";


       // for make a connection with Database
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connStr;
                    connection.Open();
                }
            }
            catch( Exception ex )
            {
                throw ex;
            } 
        }
        public void closeConn()
        {
            connection.Close();
        }


        public void ReadDataThroughAdapter( string query , DataTable dt )
        {
            try
            {
                if (connection.State == ConnectionState.Closed) createConn();

                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                closeConn();
            }
            catch(Exception ex)
            {
                throw ex;
            }         

        }

        public int ExecuteQuery( SqlCommand command )
        {
            try
            {
                if (connection.State == 0) createConn();

                command.CommandType = CommandType.Text;
                command.Connection = connection;

                int rows = command.ExecuteNonQuery();
                closeConn();
                return rows;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
