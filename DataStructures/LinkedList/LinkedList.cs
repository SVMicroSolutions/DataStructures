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
        private LinkedListNode<T> current = null; // Curret node, used to 
        private int size = 0; 
        public int Count
        {
            get { return size; }
        }
        // Add a node at the start of of the list. 
        public void AddAtStart(T t)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Next = head;
            newNode.Data = t;
            head = newNode;
            size++;
               
        }

        public void Add(T t)
        {
            size++;

            var node = new LinkedListNode<T>()
            {
                Data = t
            };

            if (head == null)
            {
                // this is the first node, make it the head
                head = node;
            }
            else
            {
                // This is not the head, Make it curret's next node
                current.Next = node;

            }


            //Makes the ewly added node the current node
            current = node;  
        }

        //Get the last Node in a List
        T GetLast()
        {
            T temp = default(T); // Return the default of the type if list is empty.
            LinkedListNode<T> current = head;

            while (current != null)
            {
                temp = current.Data;
                current = current.Next;
            }
            return temp;
        }

        // List of the nodes, for testing purposes
        public void ListNodes()
        {
            LinkedListNode<T> tempNode = head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }
        }

        // Fetch a node at a specifc position 
        public LinkedListNode<T> Retrieve(int Position)
        {
            LinkedListNode<T> tempNode = head;
            LinkedListNode<T> retNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    retNode = tempNode;
                    break;
                }                      
                count++;
                tempNode = tempNode.Next; 

            }

            return retNode; 
        }

        //Delete a Node at a specific position 
        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                if (Position == size)
                {
                    head = null;
                    current = null;
                    return true;
                }
                else if (Position > size)
                {
                    return false;
                }
                else
                {
                    head = head.Next;
                    return true;
                }

            }

            if (Position > 1 && Position <= size)
            {
                var tempNode = head;
                LinkedListNode<T> lastNode = null;
                int count = 0;

                while (tempNode != null)
                {   
                    if (count == Position - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }

            }

            return false;
        }
        // Reverse a Linked List.  

        // Detect for a circular linked list 

    }
}
