using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class LongestPalindrome
    {
        public LongestPalindrome()
        {
            string str = "babad";

            int startPointer = 0;
            int endPointer = 0;

            for(int x = 0; x< str.Length; x++)
            {
                int oddLength = ExpandFromCenter(str, x, x);
                int evenLength = ExpandFromCenter(str, x, x + 1);

                int maxLength = Math.Max(oddLength, evenLength);

                if(maxLength > (endPointer - startPointer))
                {
                    startPointer = x - (maxLength / 2);
                    endPointer = x + (maxLength / 2);
                }
            }

            Console.WriteLine(str.Substring(startPointer, endPointer - startPointer + 1));
        }

        private int ExpandFromCenter(string str, int leftPointer, int rightPointer)
        {
            if(str == null || leftPointer > rightPointer)
            {
                return 0;
            }

            while(leftPointer >= 0 && rightPointer < str.Length && str[leftPointer] == str[rightPointer])
            {
                leftPointer--;
                rightPointer++;
            }

            return rightPointer - leftPointer - 1;
        }
    }
}
