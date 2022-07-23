using GetStartedWithASPNETMVC.Utility.Filter;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // 全局异常捕捉Filter
            // 还有一部分异常捕捉在Global.asax，主要用于用户随意输入，捕捉非200的请求。
            filters.Add(new CustomExceptionFilterAttribute());
            // 全局验证Filter
            filters.Add(new CustomAuthorizeAttribute()); 
        }
    }
}
