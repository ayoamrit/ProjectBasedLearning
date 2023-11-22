using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Sorting
{
    public class MergeSorted
    {

        public MergeSorted()
        {
            int[] number1 = new int[10] { 1, 2, 3, 7, 8, 9, 10, 0, 0, 0 };
            int[] number2 = new int[3] { 2, 5, 6 };
            Merge(number1, number2, 7, number2.Length);
        }

        private void Merge(int[] Number1, int[] Number2, int length1, int length2)
        {
            int pointer1 = length1 - 1;
            int pointer2 = length2 - 1;
            int pointer = length1 + length2 - 1;

            while (pointer1 >= 0 && pointer2 >= 0)
            {
                if (Number1[pointer1] > Number2[pointer2])
                {
                    Number1[pointer] = Number1[pointer1];
                    pointer1--;
                }
                else
                {
                    Number1[pointer] = Number2[pointer2];
                    pointer2--;
                }

                pointer--;
            }

            for (int x = 0; x < Number1.Length; x++)
            {
                Console.Write(Number1[x] + " ");
            }
        }
    }
}
