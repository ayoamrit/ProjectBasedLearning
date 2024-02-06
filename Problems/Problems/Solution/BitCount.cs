using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class BitCount
    {
        public BitCount()
        {
            uint bits = 00000000000000000000000000001011;

            Console.WriteLine(Count(bits));
        }

        private int Count(uint bits)
        {
            int count = 0;

            while(bits != 0)
            {
                if(bits % 10 == 1)
                {
                    count++;
                }

                bits = bits / 10;
            }

            return count;
        }
    }
}
