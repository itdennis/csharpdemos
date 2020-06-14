using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    public class InitOnly : IDemoBase
    {
        public int MyProperty { get; set; }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
