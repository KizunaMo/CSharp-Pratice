using System;

namespace ObserverPattern_DesingnPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Youtube youtube = new Youtube();
            Client clientA = new Client(youtube,"蔡阿嘎");
            Client clientB = new Client(youtube,"瓜及");
            youtube.Subscribe(clientA);
            youtube.Subscribe(clientB);
            youtube.SendMensange();
            youtube.TEST();
            youtube.Unsubscribe(clientB);
            youtube.SendMensange();
            youtube.TEST();
        }
    }
}
