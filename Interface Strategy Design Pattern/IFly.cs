using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Strategy_Design_Pattern
{
    interface IFly
    {
        void FlyMethod();
    }




    class CanNotFly : IFly
    {
        public void FlyMethod()
        {
            Console.WriteLine($"CanNotLly");
        }
    }

    class IronMAnType : IFly
    {
        public void FlyMethod()
        {
            Console.WriteLine($"FlyByIronManType");
        }
    }

    class ThorType : IFly
    {
        public void FlyMethod()
        {
            Console.WriteLine($"FlyByThorType");
        }
    }
}
