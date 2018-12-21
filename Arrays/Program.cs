
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Item[5];
            Random r = new Random();
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item(r.Next());
            }
        }
    }
}
