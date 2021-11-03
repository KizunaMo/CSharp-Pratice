using Algorithms;
using System;
using System.Collections.Generic;


namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // (原始寫法)
            NPC npc = new NPC { talk = NPC.NormalTalk };
            npc.ToTalk();
            //若魔王死亡，修改NPC的設定
            npc.talk = NPC.BossDeadTalk;
            npc.ToTalk();//NPC本身並不知道世界發生什麼事情，只知道去執行ToTalk的函式；至於要做什麼樣的對話，由主程式來告知

            //同樣的情況 用Lambda的寫法  以Mob舉例
            Mob mob = new Mob() { talk = () => Console.WriteLine("NormalTalk") };
            mob.ToTalk();
            mob.talk = () => { Console.WriteLine("Good Job"); };
            mob.ToTalk();
            Action action = SomeMethod;
            action();

            Action<int> action1 = SomeMethod;
            action1 = x => Console.WriteLine(x);
            action1(12);

            Action<int, string> action2 = SomeMethod;
            action2 = (x, y) => Console.WriteLine($"{x} && {y}");
            action2 += (x, y) => Console.WriteLine($"{x + x} && {y + y}");
            action2(12, "Dog");

            Func<int> func = SomeMethodFunc;
            func += () => 3;
            Console.WriteLine(func());

            Func<string, bool, int> func1 = SomeMethodFunc;
            Console.WriteLine(func1("Try", true));

            Func<int, int, int, int> func2 = SomeMethodFunc;
            func2 = (x, y, z) => x + y + z;
            Console.WriteLine(func2(3, 6, 9));

            Action<Cat> catAction = cat => cat.SayMew();
            Cat cat = new Cat() { name = "WOW" };
            catAction(cat);

            Func<Cat, string> catFunc = cat => cat.name;
            Console.WriteLine(catFunc(cat));

            Calculate(cat => cat.name);
            Calculate(cat => cat.name + " Cool");
            cat.name = "LOL";
            Console.WriteLine(catFunc(cat));

            cat.Calculate(cat => cat.name);
            cat.Calculate(cat => cat.name = "LastCat");

            //練習2021/11/01
            List<Mob> mobs = new List<Mob>();
            mobs.Add(new Mob());
            Action<Mob, int> setMobHp = GetMobHp;
            setMobHp = (x, y) => { mobs[0].SetHp(y); };
            setMobHp(mobs[0], 900);
            Func<Mob, int, int> getMobHp = GetMobHpFunc;
            getMobHp = (x, y) => { return x.SetHp(y * 10); };

            Console.WriteLine($"DeBug{getMobHp(mobs[0], 999)}");
            mobs.Add(new Mob());
            Console.WriteLine($"{mobs[1].GetHp()}");
            Console.WriteLine($"{getMobHp(mobs[1], 3000)}");//透過Func功能直接修改
            Console.WriteLine($"---------");

            //練習跨類別傳遞
            Passenger passenger = new Passenger();
            Gossiping gossiping = new Gossiping();
            gossiping.Notify(passenger.RecrviveNews, " : 透過路人接收訊息的能力傳送一則訊息給他");

            npc.AddOtherMp(mob.AddMp, 100);//NPC給MOB加魔力
            Console.WriteLine($"{mob.Mp}");
            mob.AddOtherMp(npc.AddMp, 30);
            Console.WriteLine($"{npc.Mp}");
            Console.WriteLine($"---------");

            //練習 試著寫看看怪物掉落物品，背包存取物品的方法;
            Bag npcBag = new Bag();
            mob.DropItem(npc.GetItem, Item.Product(Item.itemID.Apple), npcBag);
            mob.DropItem(npc.GetItem, Item.Product(Item.itemID.Orange), npcBag);
            npcBag.ShowItems();
            Bag passengerBag = new Bag();
            mob.DropItem(passenger.GetItem, Item.Product(Item.itemID.Gun), passengerBag);
            passengerBag.ShowItems();
            Console.WriteLine($"---------");


            //測試MergeSort
            int[] numbers = { 1, 56, 98, 55, 4, 52, 6, 46, 4, 1, 2 };
            TryMerge(numbers);
            Console.WriteLine($"---------");
            int[] randomNumbers = new int[9];
            Console.WriteLine("Random Numbers \n");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = MyRandom.MersenneTwisterNextFunction(0, 666);
                Console.Write($"{randomNumbers[i]} ");
            }
            Console.WriteLine("");
            TryMerge(randomNumbers);
            Console.WriteLine($"---------");

            //測試Swap
            int a = 10;
            int b = 12;
            Console.WriteLine($"a:{a},b:{b}");
            Swapper.Swap(ref a,ref b);
            Console.WriteLine($"After Swap \na:{a},b:{b}");
            Item item1 = new Item(Item.itemID.Apple);
            Item item2 = new Item(Item.itemID.Orange);
            Console.WriteLine($"FirstItem : {item1.Name}  ,  SecondItem : {item2.Name}");
            Swapper.Swap(ref item1, ref item2);
            Console.WriteLine($"After Swap \nFirstItem : {item1.Name}  ,  SecondItem : {item2.Name}");

        }

        private static void TryMerge(int[] numbers)
        {
            numbers.DoMergeSort();
            foreach (int number in numbers)
                Console.Write($"{number}  ");
            Console.WriteLine($"Finish");
        }

        private static void SomeMethod()
        {
            Console.WriteLine("TEST");
        }
        private static void SomeMethod(int number)
        {
            Console.WriteLine($"Number{number}");
        }
        private static void SomeMethod(int number, string name)
        {
            Console.WriteLine($"Number{number} && Name:{name}");
        }

        private static int SomeMethodFunc()
        {
            Console.WriteLine("Calling");
            return 1;
        }
        private static int SomeMethodFunc(string text, bool someBool)
        {
            someBool = true;
            Console.WriteLine($"Calling {text},{someBool}");
            return 1;
        }
        private static int SomeMethodFunc(int number, int number2, int number3)
        {
            return 1;
        }

        private static void Calculate(Func<Cat, string> func)
        {
            Cat cat = new Cat();
            cat.name = "New Cat";
            string resultName = func(cat);

            Console.WriteLine($"{resultName}");
        }


        private static void GetMobHp(Mob mob, int mobHp)
        {
            mob.SetHp(mobHp);
            Console.WriteLine($"設定該怪物血量為{mob.SetHp(mobHp)}");
        }
        private static int GetMobHpFunc(Mob mob, int mobHp)
        {
            Console.WriteLine($"設定該怪物血量為{mob.SetHp(mobHp)}");
            return mob.SetHp(mobHp);
        }




    }
}
