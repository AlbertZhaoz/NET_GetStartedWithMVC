using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Utility
{
    public class FilterHelper:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("OnActionExecuting");
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("OnActionExecuted");
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Console.WriteLine("OnResultExecuting");
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Console.WriteLine("OnResultExecuted");
            base.OnResultExecuted(filterContext);
        }
    }
}