using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.CustomException
{
    public class EmptyOrNullException : Exception
    {
        public EmptyOrNullException(string value) : base($"{value} is out of range")
        {

        }
    }

    public class PositionFilledException : Exception
    {
        public PositionFilledException(string value) : base($"{value} position has already been taken.")
        {

        }
    }
}
