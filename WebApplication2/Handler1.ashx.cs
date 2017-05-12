using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");

            EFFactory.GetCurrentEFContext();
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public static class EFFactory
        {
            public static object GetCurrentEFContext()
            {
                if (HttpContext.Current.Items["EFContext"] == null)
                {
                    HttpContext.Current.Items["EFContext"] = new object();
                }
                return HttpContext.Current.Items["EFContext"];
            }
        }
    }
}