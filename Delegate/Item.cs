using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;

namespace Delegate
{
    class Item
    {
        private string name;
        public string Name { set { name = value; } get { return name; } }

        public Item()
        {

        }
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

        public static Item RandomProduct()
        {
            int itemCounts = (int)Item.itemID.Count - 1;
            return Item.Product((Item.itemID)MyRandom.MersenneTwisterNextFunction(1, itemCounts));
        }
    }
}
