using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class ConversionArray
    {
        public ConversionArray()
        {
            int[] number = { 9, 8, 8, 4, 9, 8, 8, 3, 9 };

            IList<IList<int>> numberList = FindMatrix(number);

            foreach(var list in numberList){
                foreach(var listNumber in list)
                {
                    Console.Write(listNumber + " ");
                }

                Console.WriteLine();
            }

        }

        private IList<IList<int>> FindMatrix(int[] number)
        {
            IList<IList<int>> numberList = new List<IList<int>>();
            IList<int> tempList = new List<int>();

            Array.Sort(number);
            int lastMovedNumber = int.MaxValue;
            int pointer = number.Length - 1;
            int flag = number.Length;


            while(flag >= 0)
            {
                if(pointer < 0)
                {
                    pointer = number.Length - 1;
                    numberList.Add(tempList);
                    lastMovedNumber = int.MaxValue;
                    tempList = new List<int>();


                    if (flag == 0)
                    {
                        break;
                    }
                }


                if (number[pointer] != -99 && number[pointer] != lastMovedNumber)
                {
                    tempList.Add(number[pointer]);
                    lastMovedNumber = number[pointer];
                    number[pointer] = -99;
                    flag--;
                }

                pointer--;
            }


            return numberList;
        }
    }
}
