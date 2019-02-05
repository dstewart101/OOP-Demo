using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            var r = new Random();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(r.Next());
            }

            myList.Sort();

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
