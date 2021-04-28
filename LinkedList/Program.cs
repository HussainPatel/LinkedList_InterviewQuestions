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

            Console.WriteLine(list.Head.Value);
            Console.WriteLine(list.Tail.Value);


            Console.Read();
        }
    }
}
