using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Utility.Filter
{
    public class CustomExceptionFilterAttribute: HandleErrorAttribute
    {
        /// <summary>
        /// 处理异常Filter
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new
                        {
                            DebugMessage = filterContext.Exception.Message,
                            RetValue = "",
                            PromptMsg = "发生错误，请联系管理员"
                        }
                    };
                }
                else
                {

                    filterContext.Result = new ViewResult()//短路器
                    {
                        ViewName = "~/Views/Shared/Error.cshtml",
                        ViewData = new ViewDataDictionary<string>(filterContext.Exception.Message)
                    };
                }
                filterContext.ExceptionHandled = true;//已经被我处理了

            }
        }
    }
}