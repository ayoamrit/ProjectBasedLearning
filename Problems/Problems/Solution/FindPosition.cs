using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class FindPosition
    {

        public FindPosition()
        {
            int[] numbers = { 5, 7, 7, 8, 8, 10 };
            int[] tempArray = SearchRange(numbers, 8);

            Console.WriteLine(string.Join(",", tempArray));
        }

        private int[] SearchRange(int[] numbers, int target)
        {
            int left = FindFirst(numbers, target);
            int right = FindLast(numbers, target);

            return new int[] { left, right };
        }

        private int FindFirst(int[] numbers, int target)
        {
            int leftPointer = 0;
            int rightPointer = numbers.Length - 1;
            int position = -1;

            while(leftPointer <= rightPointer)
            {
                int midPointer = leftPointer + (rightPointer - leftPointer) / 2;

                if (numbers[midPointer] >= target)
                {
                    if (numbers[midPointer] == target)
                    {
                        position = midPointer;
                    }
                    rightPointer = midPointer - 1;
                }
                else
                {
                    leftPointer = midPointer + 1;
                }
            }

            return position;
        }

        private int FindLast(int[] numbers, int target)
        {
            int leftPointer = 0;
            int rightPointer = numbers.Length - 1;
            int position = -1;
            
            while(leftPointer <= rightPointer)
            {
                int midPointer = leftPointer + (rightPointer - leftPointer) / 2;

                if (numbers[midPointer] <= target)
                {
                    if (numbers[midPointer] == target)
                    {
                        position = midPointer;
                    }
                    leftPointer = midPointer + 1;
                }
                else
                {
                    rightPointer = midPointer - 1;
                }
            }

            return position;
        }
    }
}
