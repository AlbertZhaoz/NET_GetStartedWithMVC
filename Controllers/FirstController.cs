using GetStartedWithASPNETMVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class FirstController : Controller
    {
        private readonly Logger _logger = new Logger(typeof(FirstController));
        // GET: First
        public ActionResult Index()
        {
            _logger.Debug($"{typeof(FirstController).Name}-Index");
            _logger.Warn($"{typeof(FirstController).Name}-Index");
            _logger.Info($"{typeof(FirstController).Name}-Index");
            _logger.Error($"{typeof(FirstController).Name}-Index");
            // 业务逻辑的计算
            // 结果展示给VIEW
            base.ViewBag.User1 = "yt01-008";
            base.ViewBag.User2 = "yt01-009";
            base.ViewData["company"] = "yt";
            base.TempData["temp"] = "test";
            base.HttpContext.Session["User"] = "httpcontext albertzhaoz";
            object model = "model albertzhaoz";
            base.ViewData["User1"] = "yt01-008008";
            return View(model);
            // 直接跳转到Albert界面，并将model传递过去
            // return View("Albert",model);
        }

        public ActionResult Albert()
        {
            return View();
        }

        public ActionResult TestLog4net()
        {
            _logger.Debug($"{typeof(FirstController).Name}-TestLog4net");
            _logger.Warn($"{typeof(FirstController).Name}-TestLog4net");
            _logger.Info($"{typeof(FirstController).Name}-TestLog4net");
            _logger.Error($"{typeof(FirstController).Name}-TestLog4net");
            return View();
        }

        public string AlbertDate(int year, int month, int day)
        {
            return $"{year}_{month}_{day}";
        }
    }
}