using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class Fibonacci
    {

        public Fibonacci()
        {
            for(int x = 0; x < 10; x++)
            {
                Console.Write(FibonacciRecursive(x)+" ");
            }            
        }

        private int FibonacciRecursive(int number)
        {
            if(number <= 1)
            {
                return number;
            }

            return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
        }
    }
}
