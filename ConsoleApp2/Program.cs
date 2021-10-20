using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int posion = 0b_0010;
            int status = 0;

            status = status | posion;
            string status2 = Convert.ToString(status, 2);
            Console.WriteLine(status2);

            status = status & (~posion);
            status2 = Convert.ToString(status, 2);
            Console.WriteLine(status2);

        }
    }
}
