using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class Permutation
    {
        private string str { get; set; }

        public Permutation(string str)
        {
            this.str = str;
            PermutationHelper(this.str);
        }

        public void PermutationHelper(string str)
        {
            char[] chars = str.ToCharArray();
            GeneratePermutation(chars, 0, chars.Length - 1);
        }

        private void GeneratePermutation(char[] chars, int start, int end)
        {
            if(start == end)
            {
                Console.WriteLine(new string(chars));
            }
            else
            {
                for(int x = start; x <=end; x++)
                {
                    Swap(chars, start, x);
                    GeneratePermutation(chars, start + 1, end);
                    Swap(chars, start, x);  //backtrack to get back to the original value
                }
            }
        }

        private void Swap(char[] chars, int index, int index2)
        {
            char temp = chars[index];
            chars[index] = chars[index2];
            chars[index2] = temp;
        }
    }
}
