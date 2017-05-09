using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1Container dbcontext = new Model1Container();
            //相同id的实体，只能被附加一次上下文，查询出来的实体，自动默认是已经附加到上下文中了
            //UserInfo user1 = new UserInfo();
            //user1.Username="liyi1";
            //user1.Telphone = "120";
            //user1.SubTime = DateTime.Now;
            //user1.DelFlag = 0;

            //dbcontext.Entry(user1).State = System.Data.EntityState.Added;

            //查出来的默认附加到上下文中
            var user = dbcontext.UserInfo.Where(u => u.Id == 6).FirstOrDefault();
            if (user != null)
            {
                user.Username = "liyi001";//查询出来的实体改变属性会被上下文自动捕获到变化
            }
            dbcontext.UserInfo.Remove(user);

            #region 一对多
            ////给用户下两个订单
            //Order ord = new Order();
            //ord.Content = "str";
            //ord.UserInfo = user1;//导航属性
            //dbcontext.Entry(ord).State = System.Data.EntityState.Added;
            ////user1.Order.Add(ord);
            #endregion

            #region 多对多
            //Role rol = new Role();
            //rol.RoleName = "管理员";
            //rol.UserInfo.Add(user1);
            //dbcontext.Entry(rol).State = System.Data.EntityState.Added;
            
            #endregion

            dbcontext.SaveChanges();

            Console.ReadKey();

        }
    }
}
