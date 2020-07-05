using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace demo01
{
    public class ByteTest : IDemoBase
    {
        public void Run() 
        {
            Test();
        }
        public void Test() 
        {
            // String path = @"‪C:\Users\15040\Desktop\dennis\Video\de301300c4eb9ae27a30d4fa3817b9f9.mp4";

            string fileName = "1.mp4";

            var fileBytes = File.ReadAllBytes(fileName);

            Console.WriteLine(fileBytes.Length);
        }
    }
}
