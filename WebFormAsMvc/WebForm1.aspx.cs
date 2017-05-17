using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormAsMvc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string Name { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            //this.TextBox1.Text = "123";
            //控制器三个职责
            //1.接收客户端的请求,说白了就是处理客户端的交互
            //2.调用业务逻辑层的业务逻辑
            //3.负责把数据(model)交给前台页面展示数据

            Name="从业务逻辑层获取的数据";

        }
    }
}