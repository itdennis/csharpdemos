using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.demo01.Model;

namespace webapi.demo01.Repository.Abstraction
{
    public interface IStudentRepository
    {
        /// <summary>
        /// 根据学号获取学生信息
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>学生信息</returns>
        Student GetStuInfo(string stuNo);

        /// <summary>
        /// 根据学号获取学生信息（异步）
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>学生信息</returns>
        Task<Student> GetStuInfoAsync(string stuNo);
    }
}
