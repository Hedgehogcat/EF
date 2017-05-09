using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFReview
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ModelFirstDbHmEntities dbcontext = new ModelFirstDbHmEntities();

            #region ef curd
            //如果实体是自己创建的 new 的 就可以进行attach ,然后改变状态就可以影响到数据库了
            //UserInfo use = new UserInfo();
            //use.Id = 100;
            //use.DelFlag = 0;
            //use.Username = "zs";
            ////dbcontext.UserInfo.Add(use);
            //dbcontext.UserInfo.Attach(use);
            //dbcontext.Entry(use).State = System.Data.EntityState.Added;

            //查询出来的实体,默认已经附加到上下文中了，已经被EF跟中变化了。
            //UserInfo use= dbcontext.UserInfo.Where(c=>c.Id==6).FirstOrDefault();
            //use.Username = "get1";//修改
            //dbcontext.UserInfo.Remove(use);//删除


            //linq
            //var data = from c in dbcontext.UserInfo
            //           join s in dbcontext.R_UserInfo_Department on c.Id equals s.UserInfoId
            //           join d in dbcontext.Department on s.DepartmentId equals d.Id
            //           where c.Id == 6 && c.DelFlag == 0
            //           select c;
            //foreach (var use in data)
            //{
            //    Console.WriteLine(use.Username);
            //}
            
            #endregion
            #region 第一种延迟加载机制 在使用时才查询 遍历一次查询一次数据

            //IQueryable<UserInfo> data = from c in dbcontext.UserInfo
            //                            select c;
            //var temp = data.Where(c => c.Id == 6);//中间所有的操作都是对IQueryable的 Excpression做修改而已

            //foreach (var userinfo in data)//用到IQueryable 借口集合的时候，IQuerabl集合内部的provider属性会解析xprecession,然后去做相应的查询并加载数据
            //{
            //    Console.WriteLine(userinfo.Username);
            //}
            ////foreach一次 查询一次
            //foreach (var userinfo in data)
            //{
            //    Console.WriteLine(userinfo.Username);
            //} 
            #endregion

            #region 第二种延迟加载机制

            var users = from u in dbcontext.UserInfo
                            where u.Id>=6
                            select u;

            //Iqueryable :是非常特殊接口，数据并不存放在本地，只有用到的时候通过Provider去解析Exprecession加载数据
            //List \Array\IEnumber\...本地集合
            foreach (var user in users)
            {
                Console.WriteLine(user.Username+"所有订单个数："+user.Order.Count());
                foreach (var item in user.Order)//导航属性的延迟加载，如果是实体查询出来了，那么通过导航属性去访问其他有关联的实体时候，EF会自动帮助我们查询关联表数据
                {
                    Console.WriteLine("\t\t"+item.Id+item.Content);
                }
            }

            #endregion

            dbcontext.SaveChanges();

        }
    }
}
