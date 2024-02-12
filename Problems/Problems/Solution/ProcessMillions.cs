using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class ProcessMillions
    {
        string[] passwordList { get; set; }
        public ProcessMillions()
        {
            string filePath = "D:\\passwordList.txt";
            StreamReader reader = new StreamReader(filePath);

            passwordList = File.ReadAllLines(filePath);
            int count = 0;
            foreach(string line in passwordList)
            {
                Console.WriteLine(line);
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
