using System;
using System.Collections.Generic;
using System.Text;

namespace demo01.c_8_0
{
    class C_8_0_Default_interface_methods : IDemoBase
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Run2(string input)
        {
            Console.WriteLine($"c_8_0_Default_interface_methods: {input}");
        }
    }
}
