using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApplication2
{
    public class LaomaMvcHandler:IHttpHandler
    {

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {   

            //context.Response.Write("ok");

            //根据请求，执行不同代码
            //  /UserInfo/Index
            //通过解析字符串，反射一个实例，然后执行请求字符串中的方法，将返回值传递给客户端
            string strurl = context.Request.RawUrl;
            //拿到字符串中的类名和方法名
            var strs = strurl.TrimStart('/').Split('/');
            string className = strs[0];//类名
            string methodName = strs[1];//方法名

            string fullClassName = "WebApplication2." + className;

            BaseController controller =(BaseController)Assembly.GetExecutingAssembly().CreateInstance(fullClassName);
            //先获得类型的Type,然后通过类型的Type获取方法信息对象
            MethodInfo method = Assembly.GetExecutingAssembly().GetType(fullClassName).GetMethod(methodName);

            controller.context = context;

            //调用 请求的方法执行，并拿到返回值
           object result= method.Invoke(controller,null);
            //数据写到前台
           context.Response.Write(result.ToString());
        }
    }
}