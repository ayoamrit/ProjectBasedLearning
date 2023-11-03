using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Prompt
{
    public class Prompt
    {
        
        public char getSymbol()
        {
            Console.WriteLine("Select A Symbol: \n" +
                "1. X\n"+
                "2. O\n");
            Console.Write("Your Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                return 'X';
            }
            else
            {
                return 'O';
            }
        }
    }
}
