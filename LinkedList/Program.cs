using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedListDemo.LinkedList list = new LinkedListDemo.LinkedList();

            list.AddLast(10);
            list.AddLast(15);
            list.AddLast(20);
            list.AddFirst(5);
            list.AddFirst(0);
            list.AddLast(25);
            list.AddLast(30);
            list.AddLast(35);
            list.AddLast(40);
            Console.WriteLine(list.Length());
            list.Display();

            Console.Read();
        }
    }
}
