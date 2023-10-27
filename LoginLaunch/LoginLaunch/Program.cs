using LoginLaunch.DatabaseConnect;
using LoginLaunch.UserPrompt;
using System;

namespace LoginLaunch { 

    public class Program { 

        public static void Main(string[] args)
        {
            try
            {
                new LoginPrompt().Login();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }    
    }
}