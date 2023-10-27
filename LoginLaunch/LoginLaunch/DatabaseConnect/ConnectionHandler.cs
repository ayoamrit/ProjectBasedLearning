using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LoginLaunch.CustomException;

namespace LoginLaunch.DatabaseConnect
{
    public class ConnectionHandler
    {
        //Connection string components
        private const string dataSource = "Data Source = LAPTOP-TDOJPV33\\SQLEXPRESS;";
        private const string initialCatalog = "Initial Catalog = loginLaunch;";
        private const string integratedSecurity = "Integrated Security = true;";
        private const string encrypt = "Encrypt = False";
        private const string connectionString = $"{dataSource}{initialCatalog}{integratedSecurity}{encrypt}";

        protected static SqlConnection? sqlConnection;


        public ConnectionHandler()
        {
            try
            {
                //Create a new sqlConnection with the database
                sqlConnection = new SqlConnection(connectionString);

                //Attempt to open the database connection
                sqlConnection.Open();
            }
            catch(Exception)
            {
                //Catch and handle a custom exception 
                throw new DatabaseConnectionException(); 
            }
        } 

        protected SqlCommand getCommand(string query)
        {
            //Create a sqlCommand with the given query and the established sqlConnection
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            return sqlCommand;
        }

        protected SqlDataReader getDataReader(SqlCommand sqlCommand)
        {
            //Execute the query and return a sqlDataReader for reading data
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            return dataReader;
        }

        protected void refreshConnection()
        {
            //Create a new ConnectionHandler to refresh the database connection
            new ConnectionHandler();
        }

    }
}
