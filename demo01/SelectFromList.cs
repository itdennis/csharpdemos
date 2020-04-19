using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo01
{
    public class SelectFromList : IDemoBase
    {
        private List<string> dataSource = new List<string>() { "001", "002", "003", "004", "005" };

        public void Run()
        {
            Run_v1();
            Run_v2();
        }

        public void Run_v1()
        {
            var index = 0;

            foreach (var item in dataSource)
            {
                index++;
                Console.WriteLine($"{index}. {item}");
            }
        }

        public void Run_v2()
        {
            var items = dataSource.Select((item, i) => $"{i + 1}. {item}").ToList();
            items.ForEach(i => Console.WriteLine(i));
        }
    }
}
