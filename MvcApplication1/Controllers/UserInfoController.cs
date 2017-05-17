using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class UserInfoController : Controller
    {
        //控制器下面所有的方法为Action
        //控制器必须以controler结尾，并且和Page没关系
        // GET: /UserInfo/

        public ActionResult Index()
        {
            //Request["xxx"];
            //访问业务逻辑层
            //把数据交给视图展示
            ViewData["ssss"] = "shit";
            return View();
        }
        public ActionResult showCreate()
        {
            return View();
        }
        [HttpPost]//当前方法只接受Post请求,不打标签，说明post,get都可以
        public ActionResult ProcessAdd(string txtName,string password,Data data)
        {
            string txt = Request["txtName"];
            string passWord = Request["password"];
            ViewData["ok"] = txt;
            //注册数据库
            return View("ShowSucess");
        }
        public class Data
        {
            public string txtName{get;set;}
            public string passWord{get;set;}
        }
    }
}
