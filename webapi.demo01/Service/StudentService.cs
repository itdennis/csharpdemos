using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.demo01.Model;
using webapi.demo01.Repository.Abstraction;
using webapi.demo01.Service.Abstraction;

namespace webapi.demo01.Service
{
    public class StudentService : IStudentService
    {
        /// <summary>
        /// 定义仓储层学生抽象类对象
        /// </summary>
        protected IStudentRepository StuRepository;

        /// <summary>
        /// 空构造函数
        /// </summary>
        public StudentService() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="stuRepository">仓储层学生抽象类对象</param>
        public StudentService(IStudentRepository stuRepository)
        {
            this.StuRepository = stuRepository;
        }

        /// <summary>
        /// 根据学号获取学生信息
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>学生信息</returns>
        public Student GetStuInfo(string stuNo)
        {
            var stu = StuRepository.GetStuInfo(stuNo);
            return stu;
        }

        /// <summary>
        /// 根据学号获取学生信息（异步）
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>学生信息</returns>
        public virtual async Task<Student> GetStuInfoAsync(string stuNo)
        {
            return await StuRepository.GetStuInfoAsync(stuNo);
        }
    }
}
