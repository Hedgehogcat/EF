using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EFCodeOnlyDemo
{
    public  class UserInfo
    {
        [Key]
        public int ID { get; set; }
        public string uname{get;set;}
         public ICollection<Order> Order { get; set; }
    }
}
