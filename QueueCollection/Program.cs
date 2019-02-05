using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<int>();

            myQueue.Enqueue(100);
            Console.WriteLine(myQueue.Peek());

            myQueue.Dequeue();
            //Console.WriteLine(myQueue.Peek()); // exception because queue is empty

            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }

            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }

            int val = myQueue.Dequeue();
            Console.WriteLine("first dequeued value is " + val);
            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
