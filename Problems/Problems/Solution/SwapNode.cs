using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class SwapNode
    {
        public SwapNode()
        {
            ListNode HeadNode = new ListNode(1, null);
            HeadNode.Next = new ListNode(2);
            HeadNode.Next.Next = new ListNode(3);
            HeadNode.Next.Next.Next = new ListNode(4);

            ListNode node = SwapNodes(HeadNode);

            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        private ListNode SwapNodes(ListNode HeadNode)
        {
            ListNode tempNode = new ListNode();
            ListNode activeNode = tempNode;

            while(HeadNode != null && HeadNode.Next != null)
            {
                tempNode.Next = new ListNode(Backtrack(HeadNode), null);
                tempNode.Next.Next = new ListNode(HeadNode.Value, null);

                HeadNode = HeadNode.Next.Next;
                tempNode = tempNode.Next.Next;
            }

            return activeNode.Next;
        }

        private int Backtrack(ListNode HeadNode)
        {
            return HeadNode.Next.Value;
        }
    }

    public class ListNode
    {
        public int Value;
        public ListNode Next;

        public ListNode(int value = 0, ListNode Next = null)
        {
            this.Value = value;
            this.Next = Next;
        }
    }
}
