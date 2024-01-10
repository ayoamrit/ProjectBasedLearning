using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class CountAndSay
    {
        public CountAndSay()
        {
            int number = 4;

            Console.WriteLine(SayHelper(number));
        }

        private string SayHelper(int number)
        {
            if(number == 1)
            {
                return number.ToString();
            }

            string newNumber = SayHelper(number - 1);
            string resultNumber = String.Empty;
            string digit = newNumber[0].ToString();
            int count = 0;

            for(int x = 0; x < newNumber.Length; x++)
            {
                if (newNumber[x].ToString() == digit)
                {
                    count++;
                }
                else
                {
                    resultNumber = resultNumber + count.ToString() + digit;
                    digit = newNumber[x].ToString();
                    count = 1;
                }
            }

            resultNumber += count.ToString() + digit;

            return resultNumber;
        }
    }
}
