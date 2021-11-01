using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class NPC
    {
        //原始寫法
        public  delegate void Talk();
        public Talk talk;

        private int mp = 0;
        public int Mp { set { mp = Mp; } get { return mp; } }
        public void ToTalk()
        {
            talk();
        }

        public static void NormalTalk()
        {
            Console.WriteLine("NormalTalk");
        }

        public static void BossDeadTalk()
        {
            Console.WriteLine("Good Job");
        }


        public void AddOtherMp(Action<int> action,int number)
        {
            action(number);
        }
        public void AddMp(int number)
        {
            mp += number;
        }
    }
}
