//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFReview
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInfo
    {
        public UserInfo()
        {
            this.Order = new HashSet<Order>();
            this.R_UserInfo_Department = new HashSet<R_UserInfo_Department>();
            this.Role = new HashSet<Role>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public System.DateTime SubTime { get; set; }
        public string Telphone { get; set; }
        public Nullable<int> DelFlag { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<R_UserInfo_Department> R_UserInfo_Department { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
