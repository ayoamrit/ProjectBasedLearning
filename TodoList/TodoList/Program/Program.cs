using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.LinkedList;

namespace Program
{
    public class Program
    {
        //To-Do List using linked list

        static LinkedList linkedList = new LinkedList();


        private static void Main(string[] args)
        {
            while (true)
            {
                
                string? task = getTask();

                linkedList.InsertFirst(task);
                Console.WriteLine("Task has been added to the list");

                Console.WriteLine(); //leaving a line for better formatting
                linkedList.displayList();
                Console.WriteLine(); //leaving a line for better formatting
            }
        }

        private static string? getTask()
        {
            
            Console.Write("Enter A Task: ");
            return Console.ReadLine();
        }
    }

}
