using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class FindMedian
    {
        //Find median of two sorted array

        public FindMedian()
        {
            int[] number = { 1, 2, 4, 6, 8, 10 };
            int[] number2 = { 3, 5, 7, 9, 11};

            Console.WriteLine(FindMedianHelper(number, number2));
        }

        //Function merge the arrays and find their median
        private double FindMedianHelper(int[] number, int[] number2)
        {
            //Init few pointers
            int firstPointer = 0;
            int secondPointer = 0;
            int positionPointer = 0;

            //since arrays are already sorted, we don't need to sort them
            int firstLength = number.Length;
            int secondLength = number2.Length;
            int totalLength = firstLength + secondLength;

            //Create a new array to store the sorted elements
            int[] mergeArray = new int[firstLength + secondLength];
            
            //Use while loop to transfer elements from both arrays to the mergeArray
            while(firstPointer < firstLength && secondPointer < secondLength)
            {
                //check if the specific number in the first array is larger than the element in the other array
                if (number[firstPointer] < number2[secondPointer])
                {
                    mergeArray[positionPointer] = number[firstPointer];
                    positionPointer++; //Increment position pointer
                    firstPointer++;  //Increment pointer pointing at the first array
                }
                else
                {
                    mergeArray[positionPointer] = number2[secondPointer];
                    secondPointer++;
                    positionPointer++;
                }
            }

            //Add left elements in the array
            while(firstPointer < firstLength)
            {
                mergeArray[positionPointer] = number[firstPointer];
                firstPointer++;
                positionPointer++;
            }

            //Add left elements in the array
            while(secondPointer < secondLength)
            {
                mergeArray[positionPointer] = number2[secondPointer];
                positionPointer++;
                secondPointer++;
            }

            //check if the size of the array is even or odd
            //when size is even
            if(totalLength%2 == 0)
            {
                //grab two middle elements and divide them by 2 to get the median
                int firstNumber = mergeArray[totalLength / 2];
                int secondNumber = mergeArray[(totalLength / 2) - 1];

                return (firstNumber + secondNumber) / 2;
            }
            else
            {
                //grab the middle element
                return mergeArray[totalLength / 2];
            }
        }
    }
}
