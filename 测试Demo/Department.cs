//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 测试Demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.R_UserInfo_Department = new HashSet<R_UserInfo_Department>();
        }
    
        public int Id { get; set; }
        public string DepName { get; set; }
    
        public virtual ICollection<R_UserInfo_Department> R_UserInfo_Department { get; set; }
    }
}
