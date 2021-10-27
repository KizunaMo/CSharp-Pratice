using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int posion = 0b_0010;
            int status = 0;

            status = status | posion;
            string status2 = Convert.ToString(status, 2);
            Console.WriteLine(status2);

            status = status & (~posion);
            status2 = Convert.ToString(status, 2);
            Console.WriteLine(status2);

        }

        /// <summary>
        /// 繼承可見性練習
        /// (基底)
        /// </summary>
        class NPC
        {
            int a = 10;
            protected int b = 10;
            public int c = 10;
        }
        /// <summary>
        /// (衍生)
        /// </summary>
        class Mob:NPC
        {
            /// <summary>
            /// 衍生類別
            /// </summary>
            public void Test()
            {
                //a = 15; private摸不到
                c = 15;
                b = 15;
            }
        }
        /// <summary>
        /// (外部)
        /// </summary>
        class OutSideTest
        {
            /// <summary>
            /// 外部對基底
            /// </summary>
            public void Test()
            {
                NPC npc = new NPC();
                //npc.a = 15; private 摸不到
                //npc.b = 15; protected 摸不到
                npc.c = 15; 
            }
            /// <summary>
            /// 外部對衍生
            /// </summary>
            public void Test2()
            {
                NPC mob = new Mob();
                //mob.a = 15; private 摸不到
                //mob.b = 15; protected 摸不到
                mob.c = 15;

                Mob mob1 = new Mob();
                mob1.c = 15; //同樣只能摸public 
            }
        }
    }
}
