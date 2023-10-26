using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginLaunch.CustomException;

namespace LoginLaunch.ValidateInput
{
    public class Validate
    {

        //Function to get a string input from the user
        public string getString()
        {
            string? str = Console.ReadLine();

            //check if the input string is empty or null
            if (string.IsNullOrEmpty(str))
            {
                throw new EmptyOrNullString("Value is either empty or null");
            }
            else
            {
                return str;
            }

        }

        //Function to compare two strings fpr equality
        public bool isEqualStrings(string first, string second)
        {
            //Return true if two strings are equal, otherwise return false
            return first == second ? true : false;
        }
    }
}
