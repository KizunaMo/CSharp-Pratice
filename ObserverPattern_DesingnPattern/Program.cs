using System;

namespace ObserverPattern_DesingnPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Youtube youtube = new Youtube();
            Client clientA = new Client("蔡阿嘎");
            Client clientB = new Client("瓜及");
            youtube.Subscribe(clientA);
            youtube.Subscribe(clientB);
            youtube.SendMensange("");
            youtube.Unsubscribe(clientB);
            youtube.SendMensange("");
        }
    }
}
