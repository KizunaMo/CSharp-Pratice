using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Bag
    {
        private List<Item> items;

        public void SaveItem(Item item,List<Item> items)
        {
            this.items = items;
            items.Add(item);
            Console.WriteLine($"背包儲存了一個{item.Name}");
        }

        public void UseItem()
        {

        } 

        public void ShowItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{items[i].Name}");
            }
        }
    }
}
