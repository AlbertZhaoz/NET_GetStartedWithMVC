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
            AreaRegistration.RegisterAllAreas();// ע������
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);// ע��ȫ��Filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);// ע��·��
            BundleConfig.RegisterBundles(BundleTable.Bundles);// ע��Bundles--����JS/CS��Ҫ�����
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactoryHelper()); // ʹ���Զ���Ŀ���������
        }

        /// <summary>
        /// ֻҪ����Ӧ����200����������߲�׽������׽�쳣��©��֮��
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
