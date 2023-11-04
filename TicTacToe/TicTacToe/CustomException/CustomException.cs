using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.CustomException
{
    public class EmptyOrNullException : Exception
    {
        //Exception class for handling empty or null values
        public EmptyOrNullException(string value) : base($"{value} is out of range")
        {

        }
    }

    //Exception class for handling positions that are not empty
    public class PositionNotEmptyException : Exception
    {
        public PositionNotEmptyException(int value) : base($"{value} position has already been taken.")
        {

        }
    }
}
