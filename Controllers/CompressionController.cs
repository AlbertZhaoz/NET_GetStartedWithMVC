using GetStartedWithASPNETMVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class CompressionController : Controller
    {
        // GET: Compression
        [CustomCompressionActionFilterAttribute]
        public ActionResult Index()
        {
            return View();
        }
    }
}