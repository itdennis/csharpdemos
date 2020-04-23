using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    public class Delegate : IDemoBase
    {
        public void Run()
        {
            new Action(() =>
            {
                Console.WriteLine("666");
            }).SafeInvoke();
        }
    }
}
