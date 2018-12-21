using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Demo
{
    class Warehouse
    {

        public int Id { get; set; }
        public string WarehouseName { get; set; }


        public Warehouse(string Name, int Id)
        {
            WarehouseName = Name;
            this.Id = Id;
        }
        public Item FindAndReturnItem(int itemId)
        {
            Item returnItem = new Item() { Id = itemId, Name="Microsoft Office" };
            return returnItem;
        }
    }
}
