using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCodeOnlyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoDbContext dbcontext = new DemoDbContext();
            //初始化数据
            dbcontext.Database.CreateIfNotExists();//如果没有数据库自动创建

            UserInfo userinfo = new UserInfo();
            userinfo.uname = "liyitest";
            userinfo.ID = 1010;
            dbcontext.Entry(userinfo).State = System.Data.EntityState.Added;
            dbcontext.SaveChanges();


            //webclient
            //if (SingleDemo.cureorder == null)
            //{ 

            //}
            Product p = new Product();


        }
    }
}
