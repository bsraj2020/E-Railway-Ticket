using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace E_Ticket_Pro_472
{
    class DBAccess
    {
        private static SQLiteConnection connection = new SQLiteConnection();
        private static SQLiteCommand command = new SQLiteCommand();
        private static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        // private static SqlDataReader reader = new SqlDataReader();
        private static string connStr = "Data Source=database.sqlite3";

        public DBAccess()
        {
            if(!File.Exists("/.database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }
        }

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

                adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);

                closeConn();
            }
            catch(Exception ex)
            {
                throw ex;
            }         

        }

        public bool  IS_Exist(string query)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) createConn();

                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                adapter = new SQLiteDataAdapter(command);
                DataTable dt = new DataTable() ;
                adapter.Fill(dt);
                int rows = dt.Rows.Count; 
                closeConn();
                return (rows > 0);

               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int ExecuteQuery( SQLiteCommand command )
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
