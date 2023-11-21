using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class Power
    {
        private int number { get; set; }
        private int power { get; set; }

        public Power(int number, int power)
        {
            this.number = number;
            this.power = power;

            Console.WriteLine("Power: " + getPower(this.number, this.power));
        }

        private int getPower(int num, int pow)
        {
            if(pow == 0)
            {
                return 1;
            }
            else
            {
                return number * getPower(num, pow - 1);
            }
        }
    }
}
