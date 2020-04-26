using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace demo01
{
    public class Async : IDemoBase
    {
        public void Run()
        { 
        }

        public async Task BoilWaterAsync()
        {
            // a very long operaton of boil water...
            Thread.Sleep(1000000);
            FileInfo myFile = new FileInfo(@"\bin\debug\result.txt");
            StreamWriter sw = myFile.CreateText();
            string s = "a very long operaton of boil water...";
            await sw.WriteLineAsync(s);
            sw.Close();
        }
    }
}
