using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Gossiping
    {
        public  void Notify(Action<string> action,string news)
        {
            action(news);
        }
    }
}
