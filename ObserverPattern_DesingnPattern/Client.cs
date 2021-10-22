using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DesingnPattern
{
    class Client : IObserver
    {
        Youtube youtube;
        public string name { private get; set; } = "觀察者";
        public void Update()
        {
            Console.WriteLine($"Update→{name}");
        }

        public Client(Youtube youtube,string name)
        {
            this.youtube = youtube;
            this.name = name;
        }
    }
}
