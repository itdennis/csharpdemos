using System;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            IDemoBase demo = new Nullable();
            demo.Run();
            Console.ReadKey();
        }
    }
}
