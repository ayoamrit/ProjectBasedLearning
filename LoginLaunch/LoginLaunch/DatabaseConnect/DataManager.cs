using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLaunch.DatabaseConnect
{
    public class DataManager : ConnectionHandler
    {

        //Check if the data exists in the database for a given query
        public bool checkDataInDatabase(string query)
        {
            //Create a sqlCommand with given query
            SqlCommand sqlCommand = getCommand(query);

            //Execute the query and get a data reader
            SqlDataReader dataReader = getDataReader(sqlCommand);

            while (dataReader.Read())
            {
                //Data exists in the database; return true
                return true;
            }

            //No data found; return false
            return false;
        }

        //Get data from the database for a given query
        public string getDataFromDatabase(string query)
        {
            //refresh the database connection
            refreshConnection();
            SqlCommand sqlCommand = getCommand(query);
            SqlDataReader reader = getDataReader(sqlCommand);

            while (reader.Read())
            {
                //return the first column value from the result
                return reader.GetString(0);
            }

            //No data found; return an empty string
            return string.Empty;
        }

        //Generate a SQL query to select specific data from the database
        public string generateQuery(string selectedValue,string value)
        {
            return $"select {selectedValue} from userInformation where email = '{value}'";
        }
    }
}
