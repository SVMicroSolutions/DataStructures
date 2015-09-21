using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{

    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { set; get; }
        public T Data { get; set; }
    }

    public class LinkedList<T>
    {
        private LinkedListNode<T> head = null; // List is intially empty.

        // Add a node at the start of of the list. 
        public void AddNode (T t)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Next = head;
            newNode.Data = t;
            head = newNode;
               
        }

        //Get the last Node in a List
        T GetLast()
        {
            T temp = default(T); // Return the default of the type if list is empty.

            return temp;
        }

        // Add a node After Another Node

        // Reverse a Linked List.  

        // Detect for a circular linked list 

    }
}
