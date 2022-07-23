using GetStartedWithASPNETMVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GetStartedWithASPNETMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();// 注册区域
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);// 注册全局Filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);// 注册路由
            BundleConfig.RegisterBundles(BundleTable.Bundles);// 注册Bundles--引用JS/CS需要的组件
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactoryHelper()); // 使用自定义的控制器工厂
        }

        /// <summary>
        /// 只要是响应不是200，就能在这边捕捉到，捕捉异常的漏网之鱼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception excetion = Server.GetLastError();
            Response.Write("System is Error....");
            Server.ClearError();
        }
    }
}
