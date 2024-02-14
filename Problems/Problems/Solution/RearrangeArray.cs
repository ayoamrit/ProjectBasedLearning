using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class RearrangeArray
    {
        public RearrangeArray()
        {
            int[] numberArray = new int[] { 3, 1, -2, -5, 2, -4 };
            int[] resultArray = new int[numberArray.Length];

            int positivePointer = 0;
            int negativePointer = 1;

            for(int x = 0; x < numberArray.Length; x++)
            {
                int selectedNumber = numberArray[x];

                if(selectedNumber >= 0)
                {
                    resultArray[positivePointer] = selectedNumber;
                    positivePointer += 2;
                }
                else
                {
                    resultArray[negativePointer] = selectedNumber;
                    negativePointer += 2;
                }
            }

            foreach(int number in resultArray)
            {
                Console.WriteLine(number);
            }
        }

    }
}
