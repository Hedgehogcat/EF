using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFCodeOnlyDemo
{
     public   class DemoDbContext:DbContext
    {
         public DemoDbContext()
             :base("name=demo")
         {

         }

         public DbSet<UserInfo> userinfo { get; set;}
         public DbSet<Order> order{get;set;}

    }
}
