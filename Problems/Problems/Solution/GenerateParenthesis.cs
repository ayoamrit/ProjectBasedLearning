using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class GenerateParenthesis
    {

        public GenerateParenthesis()
        {
            int number = 2;
            IList<string> list = new List<string>();
            int open = 1;
            int close = 0;

            GenerateParenthesisHelper(list, "(", open, close, number);

            foreach(string parenthesis in list)
            {
                Console.Write(parenthesis);
            }

        }

        private void GenerateParenthesisHelper(IList<string> list, string str, int open, int close, int number)
        {

            if(open == number && close == number)
            {
                list.Add(str);
                return;
            }

            if(open < number)
            {
                GenerateParenthesisHelper(list, str + "(", open + 1, close, number);
            }

            if(close < open)
            {
                GenerateParenthesisHelper(list, str + ")", open, close + 1, number);
            }


        }
    }
}
