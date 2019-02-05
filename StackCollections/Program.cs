using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<int>();

            myStack.Push(100);
            Console.WriteLine(myStack.Peek());

            myStack.Pop();
            //Console.WriteLine(myQueue.Peek()); // exception because queue is empty

            for (int i = 0; i < 50; i++)
            {
                myStack.Push(i);
            }

            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }

            int val = myStack.Pop();
            Console.WriteLine("first dequeued value is " + val);
            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
