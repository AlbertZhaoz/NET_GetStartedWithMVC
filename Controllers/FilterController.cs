using GetStartedWithASPNETMVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class FilterController : Controller
    {
        // GET: Filter
        [FilterHelper]
        public ActionResult Index()
        {
            return View();
        }
    }
}