using BalancedParentheses.Stack;

namespace Program
{
    public class Program
    {
        static Stack? stack;

        public static void Main(string[] args)
        {
            //Define a string containing sequence of brackets
            string str = "[()()]";

            //Initialize the stack with the capacity of the string length
            stack = new Stack(str.Length);

            Console.WriteLine(isBalanced(str));
        }

        //function to check if th string contains balanced parentheses
        private static bool isBalanced(string str)
        {

            for (int x = 0; x < str.Length; x++)
            {
                char c = str[x];

                if (c == '[' || c == '{' || c == '(')
                {
                    //push the opening brackets into the stack
                    stack.push(c);
                }
                else if (c == ']')
                {
                    if (stack.peek() != '[')
                    {

                        //if the stack top does not match the current closing brackets, it's unbalanced
                        return false;
                    }
                    else
                    {
                        //pop the matching opening brackets from the stack
                        stack.pop();
                    }
                }
                else if (c == '}')
                {
                    if (stack.peek() != '{')
                    {
                        return false;
                    }
                    else
                    {
                        stack.pop();
                    }
                }
                else if (c == ')')
                {
                    if (stack.peek() != '(')
                    {
                        return false;
                    }
                    else
                    {
                        stack.pop();
                    }
                }
            }

            return true;
        }
    }
}
