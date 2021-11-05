using System;
using Algorithms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1 利用位元運算 處理狀態變化
            int posion = 0b_0010;
            int status = 0;

            status = status | posion;
            string status2 = Convert.ToString(status, 2);
            Console.WriteLine(status2);

            status = status & (~posion);
            status2 = Convert.ToString(status, 2);
            Console.WriteLine(status2);


            //Part2 基底與衍生引用的關係(繼承的可見姓)
            //Base(基底函式) b = new Dev(衍生)
            Father father = new Son();
            //基底:非虛擬函式 virtual ; 衍生:非虛擬函式
            father.NotVirtual();

            //Base(基底) b = new Base
            Father father1 = new Father();
            //基底:非虛擬函式 virtual ; 衍生:非虛擬函式
            father.NotVirtual();

            //Base(基底函式) b = new Dev(衍生)
            Father father2 = new Son();
            //基底:虛擬函式  衍生:複寫虛擬函式override
            father2.Virtual();

            //Base(基底) b = new Base
            Father father3 = new Father();
            //基底:虛擬函式  衍生: 非複寫虛擬函式override(((編譯不會過)))
            //father3.Virtual();

            //Dev b = new Dev()
            Son son = new Son();
            //基底:非虛擬韓式  衍生:非虛擬函式
            son.NotVirtual();

            //Dev b = new Base()
            //Son son1 = new Father();//編譯不會過


            //Dev b = new Dev()
            Son son2 = new Son();
            //基底 : 虛擬函式  衍生:  複寫虛擬函式
            son.Virtual();

            //Part3
            //練習索引運算子
            Map map = new Map(100, 100);
            map[1, 1] = 10;

            //RamdomTest
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = MyRandom.Next(0,9);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = MyRandom.MersenneTwisterNextFunction(0, 9);
                Console.Write($"{numbers[i]} ");
            }

            


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
        class Mob : NPC
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

        /// <summary>
        /// 練習繼承與函式，動態與靜態的綁定關係
        /// </summary>
        public class Father
        {
            public virtual void Virtual()//虛擬函式
            {
            }
            public void NotVirtual()//非虛擬函式
            {
            }
        }

        class Son : Father
        {
            public override void Virtual()//複寫虛擬函式
            {
                base.Virtual();
            }
            public void NotVirtual()//非複寫虛擬函式
            {

            }
            //public void Virtual()基底:虛擬函式  衍生: 非複寫虛擬函式override(((編譯不會過)))
            //{

            //}
        }


        /// <summary>
        /// Part3
        /// </summary>
        class Map
        {
            int[][] data;//多維陣列第一種方式，依據設定決定形狀
            int[,] data2;//多維陣列第二種方式，直接列出一個矩陣
            int dx;
            int dy;
            public Map(int dx, int dy)
            {
                this.dx = dx;
                this.dy = dy;
                data = new int[dx][];//第一種方式先列出其中一段數列
                for (int i = 0; i < dx; i++)
                {
                    data[i] = new int[dy];//在每一個數列中再列出一段數列
                }

                data[1][4] = 10;//覆值 在數列(1,4)這個位置覆值為10;

                data2 = new int[dx, dy];
                data2[1, 4] = 10;
            }
            /// <summary>
            /// 練習 索引運算子
            /// </summary>
            public int this[int x, int y]
            {
                get
                {
                    if (!(x >= 0 && x < dx && y > 0 && y < dy))
                        throw new Exception();
                    return data2[x, y];
                }
                set { data2[x, y] = value; }
            }
        }



    }
}
