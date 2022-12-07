using System;
using System.Collections.Generic;

namespace W2A3_QueueStack
{
    /*
    Queue/FIFO:
               + at End
               - from Start
    Stack/LIFO:
               + at Start
               - from Start 
    */
    public class QueueStack<T>
    {
        private readonly LinkedList<T> linkedList = new LinkedList<T>();

        public void Push(T obj) { this.linkedList.AddFirst(obj); }

        public void Enqueue(T obj) { this.linkedList.AddLast(obj); }

        public void Pop() { this.linkedList.RemoveFirst(); }

        public void Dequeue() { this.linkedList.RemoveFirst(); }

        public void Display()
        {
            Console.Write("\n|");
            foreach (var item in this.linkedList)
            {
                Console.Write(" " + item + " |");
            }
            Console.WriteLine();
        }
    }
}
