using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Caramel(1,new Espresso());
            Console.WriteLine($"一杯Espresso(1) + Crarmel焦糖一份(2) 花費 = {beverage.Cost()}");
            Beverage beverage1 = new Soy(1,new Espresso());
            Console.WriteLine($"一杯Espresso(1) + Soy大豆一份(3) 花費 = {beverage1.Cost()}");

            Beverage beverage2 = new Caramel(1,new Soy(1,new Espresso()));
            Console.WriteLine($"一杯Espresso(1)+ 一份焦糖(2)跟一份大豆(3) 花費 = { beverage2.Cost()}");

            Beverage beverage3 = new Caramel(2,new Espresso());
            Console.WriteLine($"一杯Espresso(1)+兩分焦糖(2) 花費 ={beverage3.Cost()}");

            Beverage beverage4 = new Soy(3, new Caramel(2, new Espresso()));
            Console.WriteLine($"一杯Espresso(1) + 三份大豆(3) + 兩份焦糖(2)   花費 = {beverage4.Cost()}");
        }
    }
}
