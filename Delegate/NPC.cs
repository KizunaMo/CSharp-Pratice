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
    }
}
