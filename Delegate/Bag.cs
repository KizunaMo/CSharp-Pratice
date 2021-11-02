using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Bag
    {
        private List<Item> bag;

        public void SaveItem(Item item,List<Item> roleBag)
        {
            this.bag = roleBag;
            roleBag.Add(item);
            Console.WriteLine($"背包儲存了一個{item.Name}");
        }

        public void UseItem()
        {

        } 

        public void ShowItems()
        {
            for (int i = 0; i < bag.Count; i++)
            {
                Console.WriteLine($"{bag[i].Name}");
            }
        }
    }
}
