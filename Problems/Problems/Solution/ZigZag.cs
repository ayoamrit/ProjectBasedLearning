using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class ZigZag
    {
        public ZigZag()
        {
            int[,] numberArray = new int[5,5];
            int number = 15;
            ZagHelper(numberArray, number);

            for(int x = 0; x < numberArray.GetLength(0); x++)
            {
                for(int z = 0; z < numberArray.GetLength(1); z++)
                {
                    Console.Write(numberArray[x,z]+"\t");
                }
                Console.WriteLine();
            }
        }

        private void ZagHelper(int[,] numberArray, int number)
        {
            int startingNumber = 1;
            for(int x = 0; x < numberArray.GetLength(1); x++)
            {
                for(int z = x; z < numberArray.GetLength(0); z++)
                {
                    numberArray[z,x] = startingNumber;
                    startingNumber++;
                }
            }
        }
    }
}
