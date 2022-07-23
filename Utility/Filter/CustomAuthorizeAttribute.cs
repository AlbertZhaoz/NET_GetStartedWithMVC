using GetStartedWithASPMVC_SqlsugarDbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Utility.Filter
{
    public class CustomAuthorizeAttribute:AuthorizeAttribute
    {
        private string _LoginUrl = null;
        public CustomAuthorizeAttribute(string loginUrl = "~/Login/Log")
        {
            this._LoginUrl = loginUrl;
        }

        /// <summary>
        /// 当要验证权限的时候进来
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            // 能拿到httpcontext 就可以为所欲为          
            var httpContext = filterContext.HttpContext;

            // 既要检查方法是否有标记的特性，也要检查控制器上方是否有全局特性
            if (filterContext.ActionDescriptor.IsDefined(typeof(CsutomAllowAnonymousAttribute), true))
            {
                return;
            }
            else if (filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(CsutomAllowAnonymousAttribute), true))
            {
                return;
            }
            else
            if (httpContext.Session["T_CurrentUser"] == null
                || !(httpContext.Session["T_CurrentUser"] is T_CurrentUser))//为空了，
            {
                //这里有用户，有地址 其实可以检查权限
                if (httpContext.Request.IsAjaxRequest())
                //httpContext.Request.Headers["xxx"].Equals("XMLHttpRequst")
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new
                        {
                            DebugMessage = "登陆过期",
                            RetValue = ""
                        }
                    };

                }
                else
                {
                    httpContext.Session["T_CurrentUser"] = httpContext.Request.Url.AbsoluteUri;
                    filterContext.Result = new RedirectResult(this._LoginUrl);
                    //短路器：指定了Result，那么请求就截止了，不会执行action
                }
            }
            else
            {
                T_CurrentUser user = (T_CurrentUser)httpContext.Session["T_CurrentUser"];
                //this.logger.Info($"{user.Name}登陆了系统");
                return;//继续
            }
        }
    }
}