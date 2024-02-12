using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class ProcessMillions
    {   
        //Processing flag to start & abort thread
        private bool processingFlag = true;

        //Path to the passwordList file
        private string filePath = "D:\\passwordList.txt";

        public ProcessMillions()
        {
            //Read each line from the password text file
            string[] passwordList = ReadPasswordFile();

            //Start the thread to show text in console
            Thread processThread = new Thread(ProcessingThread);
            processThread.Start();

            //Sort the passwordList using QuickSort algorithm
            QuickSort(passwordList, 0, passwordList.Length - 1);

            //Write the sorted list to a text file
            WriteSortedPasswordFile(passwordList);

            //Once everything has been processed, stop the processingThread
            processingFlag = false;
            processThread.Join();  //Wait till thread has ended
        }


        //Method to read text from the password text file
        private string[] ReadPasswordFile()
        {
            return File.ReadAllLines(filePath);
        }

        //Method to write message in the console
        private void ProcessingThread()
        {
            Console.Write("Processing");

            //Write until processingFlag is false
            while (processingFlag)
            {
                Console.Write("#");

                //Sleep for 5 seconds
                Thread.Sleep(5000);
            }
        }

        //Method to write data to the text file
        private void WriteSortedPasswordFile(string[] array)
        {
            //Using stream writer
            StreamWriter writer = new StreamWriter("D:\\sortedPasswordList.txt");
            
            for(int x = 0; x < array.Length; x++)
            {
                writer.WriteLine(array[x]);
            }
        }

        //Method to sort the passwordList using quickSort algorithm
        private void QuickSort(string[] array, int startPointer, int endPointer)
        {
            if(startPointer >= endPointer)
            {
                return;
            }

            int pivot = Partition(array, startPointer, endPointer);

            QuickSort(array, startPointer, pivot - 1);  //Sort left side of the array
            QuickSort(array, pivot + 1, endPointer);  //Sort right side of the array

        }

        private int Partition(string[] array, int startPointer, int endPointer)
        {
            string pivotString = array[endPointer];

            int indexPointer = startPointer - 1;

            for(int x = startPointer; x < endPointer; x++)
            {
                if (array[x].CompareTo(pivotString) < 0)
                {
                    indexPointer++;

                    string temp = array[x];
                    array[x] = array[indexPointer];
                    array[indexPointer] = temp;
                }
            }

            indexPointer++;
            string tempString = array[indexPointer];
            array[indexPointer] = array[endPointer];
            array[endPointer] = tempString;

            return indexPointer;
        }
    }
}
