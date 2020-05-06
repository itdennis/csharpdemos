using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo01
{
    public class ToDic : IDemoBase
    {
        public void Run()
        {
            ToDicRun();
        }

        public void ToDicRun() 
        {
            List<string> lists = new List<string>() { "1", "2", "3", "4" };
            string value = "value";
            var result = lists.ToDictionary(list => list, list => value);

        }
    }
}
