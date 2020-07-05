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
            List<string> lists = new List<string>() { "1", "2", "3", "4", "4" };
            // string value = "value";
            var result = lists.Distinct().ToDictionary(list => list);

        }

        public void ToDicRun2() 
        {
            Student s1 = new Student() { Name = "1", Age = 1 };
            Student s2 = new Student() { Name = "1", Age = 11 };
            Student s3 = new Student() { Name = "2", Age = 13 };
            List<Student> students = new List<Student>() { s1, s2, s3 };
            var result = students.ToDictionary(s => s.Name, s=> s.Age);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
