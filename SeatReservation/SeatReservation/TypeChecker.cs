using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SeatReservation
{
    //TypeChecker provides methods for validating and checking data types and values
    public class TypeChecker
    {

        //Function to check if a given string can be convereted to an integer
        public bool isInteger(string getValue)
        {
            int number;
            try
            {
                number = Convert.ToInt32(getValue);
                return true;  //if the conversion is successful
            }
            catch (FormatException)
            {
                return false; //if the conversion fails
            }
        }

        //Function to check if a string is empty (null or empty)
        public bool isEmpty(string? getValue)
        {
            //return true if the string is empty, otherwise false
            return string.IsNullOrEmpty(getValue) ? true : false;
        }

        //Method to check if a given number is within a specific range (1-5)
       public bool checkNumber(int number)
       {
            //return true if the number is within the range, otherwise false
            return number > 0 && number < 6 ? true : false;
       }

        //Function to check if a given character represents a valid choice (a, b, c, d, e)
        public bool checkChar(char ch)
        {
            //return true if the character is valid choice, otherwise false
            return ch == 'a' || ch == 'b' || ch == 'c' || ch == 'd' || ch == 'e' ? true : false;
        }
    }
}
