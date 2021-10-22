using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Strategy_Design_Pattern
{
    interface IFly
    {
        void FlyMethod();
    }



    /// <summary>
    /// 不能飛行
    /// </summary>
    class CanNotFly : IFly
    {
        public void FlyMethod()
        {
            Console.WriteLine($"CanNotLly");
        }
    }
    /// <summary>
    /// 鋼鐵人模式
    /// </summary>
    class IronMAnType : IFly
    {
        public void FlyMethod()
        {
            Console.WriteLine($"FlyByIronManType");
        }
    }
    /// <summary>
    /// 索爾模式
    /// </summary>
    class ThorType : IFly
    {
        public void FlyMethod()
        {
            Console.WriteLine($"FlyByThorType");
        }
    }
}
