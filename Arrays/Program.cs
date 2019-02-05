
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

            foreach (Item item in items)
            {
                Console.WriteLine("item id is " + item.Id);
            }

            Item myItem = items[1];
            Console.WriteLine("ID of second item = {0}", myItem.Id);

            Console.WriteLine("");

            Array.Sort(items, delegate(Item item1, Item item2) {
                return item1.Id.CompareTo(item2.Id);
            });

            foreach (Item item in items)
            {
                Console.WriteLine("item id is " + item.Id);
            }
        }
    }
}
