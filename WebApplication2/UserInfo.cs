using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class UserInfo:BaseController
    {
        public string Index()
        {
            this.context.Response.Write("sss");
            return "this is userinfo ";
        }
    }
}