using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Sorting
{
    public class QuickSort
    {
        //Quick sort is a sorting algorithm, which uses a pivot, a permanent index, and swap it with other elements in the array
        //All the smaller elements in the array are on the left hand side of the pivot
        //All the larger elements in the array are on the right hand side of the pivot

        //RunTime Complexity: Best Case & Average Case: O(n log(n)), Worst Case: O(n^2) if already sorted

        public QuickSort()
        {
            int[] numbers = new int[10] { 6, 3, 7, 12, 34, 76, 2, 5, 6, 1 };
            performQuickSort(numbers, 0, numbers.Length - 1);


        }

        public void performQuickSort(int[] numbers, int startIndex, int endIndex)
        {
            if(endIndex <= startIndex)
            {
                return;
            }

            //get a pivot
            int pivot = partition(numbers, startIndex, endIndex);

            performQuickSort(numbers, startIndex, pivot - 1); //sorting left side 
            performQuickSort(numbers, pivot + 1, endIndex); //sorting right side
        }

        private int partition(int[] numbers, int startIndex, int endIndex)
        {
            int pivot = numbers[endIndex];

            int pointer = startIndex - 1;

            for(int x = startIndex; x <=endIndex; x++)
            {
                if (numbers[x] < pivot)
                {
                    pointer++;
                    int temp = numbers[x];
                    numbers[x] = numbers[pointer];
                    numbers[pointer] = temp;
                }
            }

            //Increment pointer to insert pivot to its final resting place
            pointer++;
            int temp2 = numbers[pointer];
            numbers[pointer] = numbers[endIndex];
            numbers[endIndex] = temp2;

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            return pointer;
        }
    }
}
