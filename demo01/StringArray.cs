using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    public class StringArray : IDemoBase
    {
        public void Run()
        {
            RunTest();
        }

        public void RunTest() 
        {
            string[] tests = { "1", "2" };
            Console.ReadKey();
        }

    }
}
