using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Areas.UserManagerArea.Controllers
{
    public class UserManangerController : Controller
    {
        // GET: UserManagerArea/UserMananger
        public ActionResult Index()
        {
            return View();
        }
    }
}