using System;
using System.Collections.Generic;

namespace OOP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var newWareHouse = new Warehouse("Warehouse 1", 101);
            var myItem = newWareHouse.FindAndReturnItem(101);
            Console.WriteLine("My new item is " + myItem.Name);


            var myComputer = new Computer();
            myComputer.Id = 102;

            Item mySecondComputer = new Computer();
            mySecondComputer.Id = 103;

            Computer myThirdComputer = mySecondComputer as Computer;
            string myCPUType = myThirdComputer.CPUType;
            myThirdComputer.CPUType = "Pentium";
            myThirdComputer.Name = "Super PC";
            myThirdComputer.Purchase();


            Software mySoftware = new Software();
            mySoftware.Id = 52454;
            mySoftware.ISBN = "1234567";
            mySoftware.Name = "VS2010";
            mySoftware.Purchase();

            Console.WriteLine("");
            Console.WriteLine("");

            List<Item> freshItems = Item.GetItems(10);

            foreach (Item item in freshItems)
            {
                item.Purchase();
            }
        }
    }
}
