using System;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            IDemoBase demo = new Yield();
            demo.Run();
            Console.ReadKey();
        }
    }
}
