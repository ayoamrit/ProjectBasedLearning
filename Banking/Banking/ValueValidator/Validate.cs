using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.ValueValidator
{
    public class Validate
    {

        //Function to check if a number falls within a specified limit
        public bool checkNumberRange(int minRange, int maxRange, int number)
        {
            if(number > minRange && number < maxRange)
            {
                return true;
            }
            else
            {
                //Throw an exception when the number is outside the specified limit
                throw new ArgumentOutOfRangeException();
            }
        }

        //Function to parse a string to an integer
        public int parseInt(string str)
        {
            if(int.TryParse(str, out var number))
            {
                return number;
            }
            else
            {
                //Throw an exception when parsing fails due to incorrect format
                throw new FormatException();
            }
        }
    }
}
