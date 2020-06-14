using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo01.c_8_0
{
    public class C_8_0_AsyncEnumerable : IDemoBase
    {
        public IEnumerable<int> ReadDataFromDataSource(int number) 
        {
            var sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += i; // simulate some delay operations
                yield return sum;
            }
        }

        public async Task<int> ReadDataFromDataSourceInAsync(int number) 
        {
            var sum = 0;
            for (int i = 0; i < number; i++)
            {
                // simulate some delay operations
                await Task.Delay(TimeSpan.FromSeconds(1));
                sum += i;
            }
            return sum;
        }

        public async IAsyncEnumerable<int> ReadDataFromDataSourceInAsyncStream(int number) 
        {
            var sum = 0;
            for (int i = 0; i < number; i++)
            {
                // simulate some delay operations
                await Task.Delay(TimeSpan.FromSeconds(1));
                sum += i;
                yield return sum;
            }
        }
    }

}
