﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.demo01.Model;
using webapi.demo01.Repository.Abstraction;

namespace webapi.demo01.Repository
{
    public class StudentRepository : IStudentRepository
    {
        /// <summary>
        /// 根据学号获取学生信息
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>学生信息</returns>
        public Student GetStuInfo(string stuNo)
        {
            //数据访问逻辑，此处为了演示就简单些
            var student = new Student();
            switch (stuNo)
            {
                case "10000":
                    student = new Student() { StuNo = "10000", Name = "张三", Sex = "男", Age = 20 };
                    break;
                case "10001":
                    student = new Student() { StuNo = "10001", Name = "钱七七", Sex = "女", Age = 18 };
                    break;
                case "10002":
                    student = new Student() { StuNo = "10002", Name = "李四", Sex = "男", Age = 21 };
                    break;
                default:
                    student = new Student() { StuNo = "10003", Name = "王五", Sex = "男", Age = 25 };
                    break;
            }

            return student;
        }

        /// <summary>
        /// 根据学号获取学生信息（异步）
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>学生信息</returns>
        public virtual async Task<Student> GetStuInfoAsync(string stuNo)
        {
            return await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("get student info success.");
                return this.GetStuInfo(stuNo);
                
            });
        }
    }
}
