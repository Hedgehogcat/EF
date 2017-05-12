using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCodeOnlyDemo
{
    public static class SingleDemo
    {
        public static readonly Order cureorder;
        //readonly ：只能在构造函数内部可以修改当前字段，其他地方只能只读，所以配合构造函数就能够保证线程安全而且是单例的
        //CLR帮助我们保证了静态类的构造函数植被执行一次【保证线程安全单例模式。】
        static SingleDemo()
        {
            cureorder = new Order();
        }
    }
}
