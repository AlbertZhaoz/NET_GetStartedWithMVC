using GetStartedWithASPNETMVC_EF;
using GetStartedWithASPNETMVC_Interface;
using GetStartedWithASPNETMVC_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class EFController : Controller
    {
        // GET: EF
        public ActionResult Index()
        {
            //using (SubaruDbContext subaruDbContext = new SubaruDbContext())
            //{
            //    var online = subaruDbContext.Online.Where(a=>a.ID == 4).FirstOrDefault();
            //    ViewBag.Online_Last_Station = online.Last_Station;
            //}
            //
            IOnlineService onlineService = new OnlineService(new SubaruDbContext());
            var firstOnline = onlineService.Find<Online>(6);
            ViewBag.Online_Last_Station = firstOnline.Last_Station;
            return View();
        }
    }
}