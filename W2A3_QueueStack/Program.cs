//Create custom data structure which supports operations of both Stack and Queue...

using System;

namespace W2A3_QueueStack
{
    internal class Program
    {
        static void Main()
        {
            QueueStack<string> sql = new QueueStack<string>();

            Console.WriteLine("\nEnqueue()");
            Console.WriteLine("---------");
            sql.Enqueue("QU1");
            sql.Display();

            sql.Enqueue("QU2");
            sql.Display();

            Console.WriteLine("\n\nDequeue()");
            Console.WriteLine("---------");
            sql.Dequeue();
            sql.Display();

            Console.WriteLine("\n\nPush()");
            Console.WriteLine("------");
            sql.Push("ST1");
            sql.Display();

            sql.Push("ST2");
            sql.Display();

            Console.WriteLine("\n\nPop()");
            Console.WriteLine("-----");
            sql.Pop();
            sql.Display();

            Console.WriteLine("\n");
        }
    }
}
