using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Passenger
    {
        public void RecrviveNews( string news )
        {
            Console.WriteLine($"路人接收到一則新聞內容{news}");
        }
    }
}
