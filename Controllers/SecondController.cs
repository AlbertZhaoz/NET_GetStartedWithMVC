using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 只能被子请求访问
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult ChildAction(string name)
        {
            ViewBag.Name = name;
            return View("ChildAction");
        }

        public ActionResult RazorExtend()
        {
            return View();
        }
    }
}