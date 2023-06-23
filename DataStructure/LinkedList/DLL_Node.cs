using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    internal class DLL_Node
    {
        internal int data;
        internal DLL_Node prevNode;
        internal DLL_Node nextNode;

        public DLL_Node(int d)
        {
            data = d;
            prevNode = null;
            nextNode = null;
        }
    }
}
