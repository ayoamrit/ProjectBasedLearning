using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.CustomException;

namespace Banking.Input
{
    internal class InputHandler
    {
        //Function to read a non-empty string from the console input
        public string getString()
        {
            //Read a string from the console input
            string? userInput = Console.ReadLine();

            //Check if the input is null or empty
            if (String.IsNullOrEmpty(userInput))
            {
                //Throw a new exception with a message if the input is null or empty
                throw new EmptyOrNullException("Value is either empty or null. Please provide a non-empty string");
            }
            else
            {
                //Return the non-empty and non-null input
                return userInput;
            }
        }
    }
}
