using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用ORM框架EF实现将实体变化映射到数据库中
            //1.添加edmx模型
            //2.创建一个EF访问数据库的上下文，上下文：httpcontext
            SalesERPDBEntities dbcontext = new SalesERPDBEntities();

            #region old
            #region 添加demo
            ////做一个添加操作
            ////3.创建一个TblEmployee实体
            //TblEmployee emp= new TblEmployee();
            //emp.FirstName = "liyi";
            //emp.Salary = 100;
            ////4.把实体添加到数据库中去，告诉ORM框架我要对实体做一个添加操作。
            //dbcontext.TblEmployee.Add(emp);

            #endregion

            #region 修改demo
            ////做一个添加操作
            ////3.创建一个TblEmployee实体
            //TblEmployee emp= new TblEmployee();
            //emp.EmployeeId = 11;
            //emp.FirstName = "liyitestupdate";
            //emp.Salary = 100;
            ////4.告诉上下文管理当前对象
            //dbcontext.TblEmployee.Attach(emp);
            ////5.告诉ORM框架给我映射到数据库中去
            //dbcontext.Entry(emp).State = System.Data.EntityState.Modified;

            #endregion
            //5.告诉ORM框架给我映射到数据库中去
            //dbcontext.SaveChanges(); 
            #endregion

            #region Linq
            //var data =from c in dbcontext.TblEmployee where c.EmployeeId >= 5
            //select c;//查询部分列
            ////微软并没有讲 数据库中的所有的数据都加载到内存里面来，再进行过滤的。而是将linq表达式转成响应的sql脚本。
            //foreach (var classInfo in data)
            //{
            //    Console.WriteLine(classInfo.EmployeeId + classInfo.LastName);
            //} 

            //Console.ReadKey();
            #endregion

            #region lambda

            ////Func<ClassInfo,bool> // 传入是ClassInfo 返回是bool

            //IQueryable<ClassInfo> data = dbContext.ClassInfo.Where(c=>c.ClassId >= 5 && c.ClassName.Contains("Java"));

            //foreach (var classInfo in data)
            //{
            //    Console.WriteLine(classInfo.ClassId + classInfo.ClassName);
            //} 

            IQueryable<TblEmployee> date1 = dbcontext.TblEmployee.Where(c => c.EmployeeId >= 5);
            foreach (var classInfo in date1)
            {
                Console.WriteLine(classInfo.EmployeeId + "-==" + classInfo.LastName);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
