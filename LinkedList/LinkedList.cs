using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        private LinkedListNode head;
        private LinkedListNode tail;
        private int size;
        
        public void AddLast(int value)
        {
            // fisrt thing is to wrap this value inside node object 
            var node = new LinkedListNode(value);

            // next there are some scenarios
            //if the linked list is empty - we need to point the head and tail to the new node created
            // else we need to append the node at the end of the list            
            if (IsEmpty())
            {
                head = node;                 
            }
            else
            {
                tail.Next = node;              
            }

            tail = node;
            size++;

        }

        public int Length() => size;

        public bool IsEmpty() => head == null;

        public void Display()
        {
            var current = head;

            while (current != null)
            {
                Console.Write(current.Value + " ---> ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        
        public void AddFirst(int value)
        {
            var node = new LinkedListNode(value);

            if (IsEmpty())
            {
                head = node;
            }
            else
            {
                node.Next = head;
                head = node;
                //var tmp = head;
                //head = node;
                //head.Next = tmp;
            }
            size++;
        }
    }
}
