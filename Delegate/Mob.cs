using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Mob
    {
        //用Lambda的寫法
        public Action talk { set; private get; }
        private int hp = 1;
        private int mp = 10;
        public int Mp { set { mp = Mp; } get { return mp; } }

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

    }
}
