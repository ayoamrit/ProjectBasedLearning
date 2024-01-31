using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class GreedyJump
    {
        public GreedyJump()
        {
            int[] numbers = { 2, 3, 1, 1, 4 };

            Console.WriteLine(GetJump(numbers));
        }

        private int GetJump(int[] numbers)
        {
            int numberJump = 0;
            int pointer = 0;

            if(numbers.Length <= 1)
            {
                return numbers.Length;
            }

            while(pointer < numbers.Length - 1)
            {
                pointer = pointer + numbers[pointer];

                if(pointer != numbers.Length - 1)
                {
                    numberJump++;
                }
            
            }

            return numberJump;
        }
    }
}
