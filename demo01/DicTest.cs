using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    public class DicTest : IDemoBase
    {
        public void Run() 
        {
            Dictionary<int, int> test = new Dictionary<int, int>();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine(i);
                test.Add(i, i);
            }
        }
    }
}
