using LoginLaunch.DatabaseConnect;
using LoginLaunch.UserAccount;
using LoginLaunch.UserPrompt;
using System;

namespace LoginLaunch { 

    public class Program {

        //create an instance of the LoginPrompt class for user login
        static LoginPrompt loginPrompt = new LoginPrompt();
        
        //Create an instance of the DataManager class for data management
        static DataManager dataManager = new DataManager();

        //Declare an Account object to store user account information
        static Account? account;

        public static void Main(string[] args)
        {

            //prompt the user login and store the result in the 'flag' variable
            bool flag = new LoginPrompt().Login();

            //get the email entered during login
            string? email = LoginPrompt.email;

            //check if the login was successful
            if (flag)
            {
                //Insert user information into the data store and store the account details
                account = dataManager.insertUserInformation(email);

                //display the user account information
                Console.WriteLine(account.ToString());
            }
        }    
    }
}