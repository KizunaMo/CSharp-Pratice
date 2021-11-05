using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;

namespace Delegate
{
    class Mob
    {
        //用Lambda的寫法
        public Action talk { set; private get; }
        private int hp = 1;
        private int mp = 10;
        public int Mp { set { mp = value; } get { return mp; } }

        public void ToTalk()
        {
            talk();
        }

        public int SetHp(int hp)
        {
            this.hp = hp;
            return this.hp;
        }

        public int GetHp()
        {
            return hp;
        }

        public void AddMp(int number)
        {
            Console.WriteLine($"被增加魔力{number}點");
            this.mp += number;
        }

        public void AddOtherMp(Action<int> action , int howMuchMp)
        {
            action(howMuchMp);
        }

        /// <summary>
        /// 怪獸掉落物品
        /// </summary>
        /// <param name="action">誰獲得物品</param>
        /// <param name="item">獲得什麼物品</param>
        /// <param name="bag">物品放進哪個背包</param>
        public void DropItem(Action<Item,Bag> action,Item item,Bag bag)
        {
            action(item,bag);
        }

        public Item OnlyDropItem(Func<Item> func)
        {
            return func();
        }

    }
}
