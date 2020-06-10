using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace demo01
{
    public class Nullable : IDemoBase
    {
        public DateTime? EndTime { get; set; }

        public Nullable()
        {
            EndTime = DateTime.UtcNow;
        }
        public void Run()
        {
            RunTest1();
        }

        public void RunTest1()
        {
            if (this.EndTime == null)
            {
                Console.WriteLine("entime is null");
            }
            else
            {
                var value = (DateTime)this.EndTime;
            }
        }

    }
}
