using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class Factorial
    {
        private int number { get; set; }

        public Factorial(int number)
        {
            this.number = number;
            Console.Write(getFactorial(this.number));
        }

        private int getFactorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            else
            {
                return num * getFactorial(num - 1);
            }
        }

    }
}
