using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DesingnPattern
{
    interface IObserverable
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void NotifyObservers();
    }
}
