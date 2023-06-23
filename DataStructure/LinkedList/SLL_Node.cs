using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    internal class SLL_Node
    {
        internal int data;
        internal SLL_Node next;
        public SLL_Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
