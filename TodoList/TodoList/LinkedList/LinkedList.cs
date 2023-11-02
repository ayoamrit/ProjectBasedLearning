using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.LinkedList
{
    public class LinkedList
    {
        //represent head of the node
        Node? Head { get; set; }

        public LinkedList()
        {
            //Linked lists are like trains or people holding hands together
            //each node or object is connected to each other 

            //Time complexity of LinkedList is O(1), constant, for insertion, if done at head, and O(N), linear, if done at any other location.
        }


        public void InsertFirst(string data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertLast(string data)
        {
            Node currentNode = Head;

            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            Node newNode = new Node();
            newNode.Data = data;

            currentNode.Next = newNode;
        }


        public void RemoveFirst()
        {
            Node newNode = new Node();
            newNode = Head.Next;

            Head = newNode;
        }

        public void RemoveLast()
        {
            Node currentNode = Head;

            while(currentNode.Next.Next != null)
            {
                if(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
            }

            currentNode.Next = null;
        }

        public void displayList()
        {
            Node currentNode = Head;
            int taskNumber = 1;

            while(currentNode != null)
            {
                Console.WriteLine($"{taskNumber}. {currentNode.Data}");
                currentNode = currentNode.Next;
                taskNumber++;
            }


        }

    }
}
