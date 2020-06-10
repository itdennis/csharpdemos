using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    public class refout : IDemoBase
    {
        public void Run()
        {
            int refRes = 0;
            RunRef(ref refRes);
            Console.WriteLine(refRes);

            int outRes;
            RunOut(out outRes);
            Console.WriteLine(outRes);
        }

        public void RunRef(ref int value1) 
        {
            value1 = 9;
        }

        public void RunOut(out int value2)
        {
            int value = 10;
            value2 = value;
        }
    }
}
