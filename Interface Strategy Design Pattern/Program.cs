using System;

namespace Interface_Strategy_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IronMan ironMan = new IronMan(new IronMAnType());
            ironMan.FlyMethod();


            TheAvengers hulk = new Hulk(new CanNotFly());
            hulk.FlyMethod();

        }
    }
}
