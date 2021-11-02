using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Item
    {
        private string name;
        public string Name { set { name = Name; } get { return name; } }

        public Item(itemID itemID)
        {
            this.name = itemID.ToString();
        }
        public enum itemID
        {
            Nothing,
            Apple ,
            Orange,
            Gun,
            Sugar,
            Count,
        }
        public static Item Product(itemID itemID)
        {   
            Console.WriteLine($"OK~Product {itemID}!");
            Item product = new Item(itemID);
            return product;
        }
    }
}
