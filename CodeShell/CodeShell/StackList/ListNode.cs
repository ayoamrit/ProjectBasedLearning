using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.StackList
{
    public class ListNode
    {
        public string Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(string Value = null, ListNode Next = null)
        {
            this.Value = Value;
            this.Next = Next;
        }
    }
}
