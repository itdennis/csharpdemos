using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    public class ParallelDemo : IDemoBase
    {
        public void Run() 
        {
            Test();
        }

        public void Test() 
        {
            var dicts = new ConcurrentDictionary<string, int>();

            Parallel.ForEach(Enumerable.Range(0, 10), async index =>
            {
                var result = await AsyncTask(index);

                dicts.TryAdd(index.ToString(), result);
            });

            Console.WriteLine($"element count in dictionary {dicts.Count}");
        }

        static async Task<int> AsyncTask(int i)
        {
            await Task.Delay(100);

            var calculate = i * 2;

            Console.WriteLine(calculate);

            return calculate;
        }
    }
}
