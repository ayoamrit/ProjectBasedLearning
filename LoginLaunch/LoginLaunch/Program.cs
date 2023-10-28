using LoginLaunch.DatabaseConnect;
using LoginLaunch.UserAccount;
using LoginLaunch.UserPrompt;
using System;

namespace LoginLaunch { 

    public class Program {

        static LoginPrompt loginPrompt = new LoginPrompt();
        static DataManager dataManager = new DataManager();
        static Account? account;

        public static void Main(string[] args)
        {
            bool flag = new LoginPrompt().Login();
            string? email = LoginPrompt.email;

            if (flag)
            {
                account = dataManager.insertUserInformation(email);
                Console.WriteLine(account.ToString());
            }
        }    
    }
}