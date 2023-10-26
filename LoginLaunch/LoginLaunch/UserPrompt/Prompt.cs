using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginLaunch.ValidateInput;

namespace LoginLaunch.UserPrompt
{
    public class Prompt
    {

        protected Validate validate = new Validate();
        //public bool checkExistence();

        protected bool checkEmailInJson(string email)
        {
            return false;
        }

        protected string getPasswordFromJson(string email)
        {
            return "Amrit";
        }
    }
}
