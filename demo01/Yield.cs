using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo01
{
    public class Yield : IDemoBase
    {
        public static IEnumerable<int> GetList(int[] nums)
        {
            foreach (var num in nums)
            {
                yield return num;
            }
        }

        public void Run()
        {
            IEnumerable<int> items = GetList_v2(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Begin to iterate the items from GetList_v2.");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }


            IEnumerable<int> items_GetList_v3 = GetList_v3(new int[] { 6, 7, 8, 9, 10 });
            Console.WriteLine("Begin to iterate the items from GetList_v3.");
            foreach (var item in items_GetList_v3)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerable<int> GetList_v1(int[] nums)
        {
            List<int> result = new List<int>();
            Console.WriteLine("Begin to invoke GetList_v1() method");
            foreach (var num in nums)
            {
                Console.WriteLine($"Processing {num}");
                Thread.Sleep(1000);
                if (num % 2 == 0)
                {
                    result.Add(num);
                };
            }
            return result;
        }

        public IEnumerable<int> GetList_v2(int[] nums)
        {
            Console.WriteLine("Begin to invoke GetList_v2() method");
            return nums.Where(num =>
            {
                Console.WriteLine($"Processing {num}");
                Thread.Sleep(1000);
                return num % 2 == 0; 
            });
        }

        public IEnumerable<int> GetList_v3(int[] nums)
        {
            Console.WriteLine("Begin to invoke GetList_v3() method");
            foreach (var num in nums)
            {
                Console.WriteLine($"Processing {num}");
                Thread.Sleep(1000);
                if (num % 2 == 0) 
                {
                    yield return num;
                }
            }
        }
    }
}
