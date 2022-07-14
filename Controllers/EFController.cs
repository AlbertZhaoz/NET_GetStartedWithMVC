using GetStartedWithASPNETMVC.Utility;
using GetStartedWithASPNETMVC_EF;
using GetStartedWithASPNETMVC_Interface;
using GetStartedWithASPNETMVC_Services;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class EFController : Controller
    {
        private readonly DIFactoryHelper dIFactoryHelper = new DIFactoryHelper();

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

        public ActionResult UnityIndex()
        {
            // Unity在MVC中的应用       
            IOnlineService service = DIFactoryHelper.GetContainer().Resolve<IOnlineService>();
            var online = service.Find<Online>(7);
            base.ViewBag.Last_Result = online.Last_Result;
            return View();
            
        }
    }
}