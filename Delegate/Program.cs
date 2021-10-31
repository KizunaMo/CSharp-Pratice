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

    }
}
