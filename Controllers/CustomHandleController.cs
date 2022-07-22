using GetStartedWithASPNETMVC.Utility.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class CustomHandleController : Controller
    {
        // GET: CustomHandle
        [CustomHandleErrorAttribute]
        public ActionResult Index()
        {
            int i =1;
            int y = 0;
            int z = i / y;
            return View();
        }
    }
}