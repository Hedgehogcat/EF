using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }
        //管道当中第一个事件
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //在第七个事件之后，根据请求的地址创建页面对象
            //如果你指定对象，RemapHandler()
            Context.RemapHandler(new LaomaMvcHandler());//再次指定了对象，那么11和12个事件之间就直接到了该对象
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}