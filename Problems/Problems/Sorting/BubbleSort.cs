using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Sorting
{
    public class BubbleSort
    {
        //Declare an array
        private int[] numbers { get; set; }

        public BubbleSort()
        {
            //Initializing the array
            numbers = new int[10] { 6, 3, 7, 12, 34, 76, 2, 5, 6, 1 };
            performSorting(numbers);
        }

        private void performSorting(int[] numbers)
        {
            for(int x = 0; x < numbers.Length; x++)
            {
                for(int y = (x+1); y < numbers.Length; y++)
                {
                    if (numbers[x] > numbers[y])
                    {
                        int temp = numbers[y];
                        numbers[y] = numbers[x];
                        numbers[x] = temp;
                    }
                }
            }

            foreach(int x in numbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}
