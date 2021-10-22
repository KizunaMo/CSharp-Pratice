using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DesingnPattern
{
    class Client : IObserver
    {
        public string name { private get; set; } = "觀察者";
        public void Update(string content)
        {
            Console.WriteLine($"Update→{name} {content}");
        }

        public Client(string name)
        {
            this.name = name;
        }
    }
}
