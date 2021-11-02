using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Passenger
    {
        private Bag bag;
        private List<Item> passengerBag = new List<Item>();

        public void RecrviveNews( string news )
        {
            Console.WriteLine($"路人接收到一則新聞內容{news}");
        }
        /// <summary>
        /// 獲得物品
        /// </summary>
        /// <param name="item">獲得什麼物品</param>
        /// <param name="bag">放在哪個背包</param>
        public void GetItem(Item item, Bag bag)
        {
            this.bag = bag;
            Console.WriteLine($"Passenger get {item.Name}!");
            this.bag.SaveItem(item, passengerBag);
        }
    }
}
