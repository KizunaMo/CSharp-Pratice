using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Cat
    {
        public string name { set; get; } = "NormalCat";

        public void SayMew()
        {
            Console.WriteLine("Mew");
        }

        public void Calculate(Func<Cat, string> func)
        {
            Cat cat = new Cat();
            name = func(cat);

            Console.WriteLine($"{name}");
        }
    }
}
