using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class SquareRoot
    {
        private int number { get; set; }

        public SquareRoot(int number)
        {
            this.number = number;

            Console.WriteLine($"The Square Root of {number} is: {getSquareRoot(number, 0)}");
        }

        private int getSquareRoot(int number, double x)
        {
            if(number == 1)
            {
                return number;
            }
            else
            {
                if(x * x > number)
                {
                    return Convert.ToInt32(x - 1);
                }
                else
                {
                    return getSquareRoot(number, x + 1);
                }
            }
        }
    }
}
