using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCodeOnlyDemo
{
    public class Product
    {
        private Product()
        {
        }
        private static Product _p;
        public static Product GetProduct()
        {
            //"sss" 字符串需要和其他地方锁冲突
            lock ("sss")
            {
                if (_p == null)
                { _p = new Product(); }
            }
            return _p;
        }
    }
}
