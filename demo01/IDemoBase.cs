using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    interface IDemoBase
    {
        public void Run() 
        {
            Console.WriteLine($"IDemoBase running.");
        }

        public void Run2(string input) 
        {
            Console.WriteLine($"IDemoBase: {input}");
        }
    }
}
