using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public LinkedListNode Head;
        public LinkedListNode Tail;


        public void AddFirst(int value)
        {
            
        }

        public void AddLast(int value)
        {
            // fisrt thing is to wrap this value inside node object 
            var node = new LinkedListNode(value);

            // next there are some scenarios
            //if the linked list is empty - we need to point the head and tail to the new node created
            // else we need to append the node at the end of the list

            //check null
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }


        }
    }
}
