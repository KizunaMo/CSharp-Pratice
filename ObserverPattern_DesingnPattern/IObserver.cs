using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DesingnPattern
{
    interface IObserver
    {
        public void Update(string content);
    }
}
