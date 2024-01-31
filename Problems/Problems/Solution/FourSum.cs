using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class FourSum
    {
        public FourSum()
        {
            int[] array = { 1000000000, 1000000000, 1000000000, 1000000000 };
            int target = -294967296;

            IList<IList<int>> parentList = new List<IList<int>>();

            SumHelper(array, target, parentList);
        }

        private void SumHelper(int[] number, int target, IList<IList<int>> parentList)
        {
            Array.Sort(number);

            for (int x = 0; x < number.Length - 3; x++)
            {

                if (x > 0 && number[x] == number[x - 1])
                {
                    continue;
                }

                for (int y = x + 1; y < number.Length - 2; y++)
                {

                    if (y > (x + 1) && number[y] == number[y - 1])
                    {
                        continue;
                    }
                    int leftPointer = y + 1;
                    int rightPointer = number.Length - 1;

                    while (leftPointer < rightPointer)
                    {
                        long numberSum = (long)number[x] + (long)number[y] + (long)number[leftPointer] + (long)number[rightPointer];

                        if (numberSum == target)
                        {
                            parentList.Add(new List<int>() { number[x], number[y], number[leftPointer], number[rightPointer] });

                            while (leftPointer < rightPointer && number[leftPointer] == number[leftPointer + 1])
                            {
                                leftPointer++;
                            }
                            while (leftPointer < rightPointer && number[rightPointer] == number[rightPointer - 1])
                            {
                                rightPointer--;
                            }
                            leftPointer++;
                            rightPointer--;
                        }
                        else if (numberSum < target)
                        {
                            leftPointer++;
                        }
                        else
                        {
                            rightPointer--;
                        }
                    }
                }
            }
        }
    }
}
