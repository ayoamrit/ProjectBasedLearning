using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLaunch.UserPrompt
{
    public class RegisterPrompt : Prompt
    {
        private string firstname { get; set; } = string.Empty;
        private string lastname { get; set; } = string.Empty;
        private string email { get; set; } = string.Empty;
        private string password { get; set; } = string.Empty;
        private string[]? hobbies { get; set; }

        public RegisterPrompt()
        {
            this.firstname = getUserInformation("Firstname");
            this.lastname = getUserInformation("Lastname");
            this.email = getUserInformation("Email");
            this.password = getUserInformation("Password");
        }

        private string getUserInformation(string printable)
        {
            Console.Write($"{printable}: ");
            return validate.getString();
        }
    }
}
