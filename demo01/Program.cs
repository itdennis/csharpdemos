using demo01.c_8_0;
using System;
using System.Linq;
using System.Threading;

namespace demo01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //{
            //    C_8_0_AsyncEnumerable demo = new C_8_0_AsyncEnumerable();
            //    foreach (var item in demo.ReadDataFromDataSource(10))
            //    {
            //        Console.WriteLine($"Thread Num: {Thread.CurrentThread.ManagedThreadId}, ReadDataFromDataSource: {item}");
            //    }

            //    MainAsync().Wait();
                
            //}

            {
                IDemoBase demo = new ParallelDemo();
                demo.Run();
            }


            Console.ReadKey();
        }

        private static async System.Threading.Tasks.Task MainAsync()
        {
            C_8_0_AsyncEnumerable demo = new C_8_0_AsyncEnumerable();
            await foreach (var item in demo.ReadDataFromDataSourceInAsyncStream(10))
            {
                Console.WriteLine($"Thread Num: {Thread.CurrentThread.ManagedThreadId},ReadDataFromDataSourceInAsyncStream: {item}");
            }
        }
    }
}
