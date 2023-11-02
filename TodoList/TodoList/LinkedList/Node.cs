using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.LinkedList
{
    public class Node
    {
        //store data of the current node
        public string? Data { get; set; }

        //reference to the next node/object
        public Node? Next { get; set; }

    }
}
