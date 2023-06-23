using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    internal class VariousOpsOnLinkedList
    {
        #region Insert Data From Front

        internal void InsertFront(SingleLinkedList singlyList, int new_Data)
        {
            SLL_Node new_Node = new SLL_Node(new_Data);
            new_Node.next = singlyList.head;
            singlyList.head = new_Node;
        }

        internal void InsertFront(DoubleLinkedList doublyList, int new_data)
        {
            DLL_Node new_Node = new DLL_Node(new_data);
            new_Node.nextNode = doublyList.head;
            new_Node.prevNode = null;
            if (doublyList.head != null)
            {
                doublyList.head.prevNode = new_Node;
            }
            doublyList.head = new_Node;
        }

        #endregion

        #region Insert Data From End

        #region For Single Linked List


        internal void InsertEnd(SingleLinkedList singlyList, int new_Data)
        {
            SLL_Node new_Node = new SLL_Node(new_Data);

            if (singlyList.head == null)
                singlyList.head = new_Node;

            SLL_Node last_Node = GetLastNode(singlyList);
            last_Node.next = new_Node;
        }

        internal SLL_Node GetLastNode(SingleLinkedList singlyList)
        {
            SLL_Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        #endregion

        #region For Double Linked List

        internal void InsertEnd(DoubleLinkedList doublyList, int new_Data)
        {
            DLL_Node new_Node = new DLL_Node(new_Data);

            if (doublyList.head == null)
            {
                new_Node.prevNode = null;
                doublyList.head = new_Node;
            }

            DLL_Node last_Node = GetLastNode(doublyList);
            last_Node.nextNode = new_Node;
            new_Node.prevNode = last_Node;

        }

        internal DLL_Node GetLastNode(DoubleLinkedList doublyList)
        {
            DLL_Node temp = doublyList.head;
            while (temp.nextNode != null)
            {
                temp = temp.nextNode;
            }
            return temp;
        }

        #endregion

        #endregion

        #region Insert data after a given node of Linked List

        internal void InsertAfter(SLL_Node prevNode, int new_Data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            SLL_Node new_Node = new SLL_Node(new_Data);

            new_Node.next = prevNode.next;
            prevNode.next = new_Node;
        }

        internal void InsertAfter(DLL_Node prevNode, int new_Data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            DLL_Node new_Node = new DLL_Node(new_Data);

            new_Node.nextNode = prevNode.nextNode;
            new_Node.prevNode = prevNode;
            prevNode.nextNode = new_Node;

            if (new_Node.nextNode != null)
            {
                new_Node.nextNode.prevNode = new_Node;
            }
        }

        #endregion

        #region Delete a node from Linked List using a given key value
        internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)
        {
            SLL_Node temp = singlyList.head;
            SLL_Node prev = null;

            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        internal void DeleteNodebyKey(DoubleLinkedList doublyList, int key)
        {
            DLL_Node temp = doublyList.head;


            if (temp != null && temp.data == key)
            {
                doublyList.head = temp.nextNode;
                doublyList.head.prevNode = temp.prevNode;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.nextNode;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.nextNode != null)
            {
                temp.prevNode.nextNode = temp.prevNode;
            }
            if (temp.prevNode != null)
            {
                temp.prevNode.nextNode = temp.nextNode;
            }
        }
        #endregion

        #region Reverse a Singly Linked list
        internal void ReverseLinkedList(SingleLinkedList singlyList)
        {
            SLL_Node current = singlyList.head;

            SLL_Node prev = null;
            SLL_Node next = null;

            if (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            singlyList.head = prev;
        }

        #endregion
    }
}
