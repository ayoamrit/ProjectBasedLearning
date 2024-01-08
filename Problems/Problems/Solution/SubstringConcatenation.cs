using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class SubstringConcatenation
    {
        public SubstringConcatenation()
        {
            string str = "lingmindraboofooowingdingbarrwingmonkeypoundcake";
            string[] words = { "fooo", "barr", "wing", "ding", "wing" };

            IList<int> list = FindSubstring(str, words);

            foreach(int number in list)
            {
                Console.WriteLine(number);
            }
            

        }

        public IList<int> FindSubstring(string str, string[] words)
        {
            IList<int> list = new List<int>();
            IList<string> wordsList = new List<string>();
            Permutation(wordsList, 0, words.Length - 1, words);

            for (int x = 0; x <= (str.Length - wordsList[0].Length); x++)
            {
                for (int y = 0; y < wordsList.Count; y++)
                {
                    if (str.Substring(x, wordsList[y].Length) == wordsList[y])
                    {
                        list.Add(x);
                        break;
                    }
                }
            }

            return list;
        }

        private void Permutation(IList<string> wordsList, int start, int end, string[] array)
        {
            if(start == end)
            {
                wordsList.Add(string.Join("", array));
            }
            else
            {
                for(int x = start; x <= end; x++)
                {
                    Swap(array, start, x);
                    Permutation(wordsList, start + 1, end, array);
                    Swap(array, start, x);
                }
            }
        }

        private void Swap(string[] array, int firstIndex, int secondIndex)
        {
            string temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

    }
}
