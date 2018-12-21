using System;

namespace OOP_Demo
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public static Item GetItem()
        {
            var newItem = new Item() { Id = 1234, Name = "Brand New Item" };
            return newItem;
        }
    }

    public class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            Console.WriteLine("Buying {0} ({2}), that has the ISBN {1}", Name, ISBN, Id);
        }
    }

    public class HardWare : Item
    {
        public string SerialNumber { get; set; }
    }

    public class Computer : HardWare
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }

    public class Peripheral : HardWare
    {
        public string Description { get; set; }
    }
}