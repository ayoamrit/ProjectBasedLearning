using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginLaunch.DatabaseConnect;
using LoginLaunch.ValidateInput;
using LoginLaunch.CustomException;

namespace LoginLaunch.UserPrompt
{
    public class Prompt
    {
        private static DataManager dataManager = new DataManager();
        protected Validate validate = new Validate();
 
        protected bool checkEmailInDatabase(string email)
        {
            
            string query = dataManager.generateQuery("email", email);

            if (dataManager.checkDataInDatabase(query))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        protected string getPasswordFromDatabase(string email)
        {
            string query = dataManager.generateQuery("password", email);
            string password = dataManager.getDataFromDatabase(query);

            return password;
        }
    }
}
