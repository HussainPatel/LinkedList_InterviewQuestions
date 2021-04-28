using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedListNode
    {
        public int Value;
        public LinkedListNode Next;

        public LinkedListNode(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return "Node: " + Value;
        }
    }
}
