using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class LongestSubsequence
    {
        public LongestSubsequence()
        {
            string str1 = "abcde";
            string str2 = "ace";
            Console.WriteLine(LongestCommonSubsequence(str1, str2));
        }

        public int LongestCommonSubsequence(string text1, string text2)
        {
            int firstLength = text1.Length;
            int secondLength = text2.Length;
            int[,] dArray = new int[firstLength + 1, secondLength + 1];

            for (int x = 0; x <= firstLength; x++)
            {
                for (int z = 0; z <= secondLength; z++)
                {
                    if (x == 0 || z == 0)
                    {
                        dArray[x, z] = 0;
                    }
                    else if (text1[x - 1] == text2[z - 1])
                    {
                        dArray[x, z] = dArray[x - 1, z - 1] + 1;
                    }
                    else
                    {
                        dArray[x, z] = Math.Max(dArray[x - 1, z], dArray[x, z - 1]);
                    }
                }
            }

            return dArray[firstLength, secondLength];
        }
    }
}
