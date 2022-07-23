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
    public class BuilderControllerFactoryController: Controller
    {
        // 这个控制器用来通过构造函数注入服务
        private readonly ICustomService _service = null;

        public BuilderControllerFactoryController(ICustomService service)
        {
            _service = service;
        }

        #region 扩展：属性注入和方法注入
        //属性注入
        [Dependency]
        public ICustomService _IOnlineServiceProp { get; set; }

        private ICustomService _IOnlineServiceMethod { get; set; }

        /// <summary>
        /// 方法注入
        /// </summary>
        /// <returns></returns>
        [InjectionMethod]
        public void SetICompanyServiceMethod(ICustomService iOnlineService)
        {
            _IOnlineServiceMethod = iOnlineService;
        }
        #endregion

        public ActionResult BuilderIndex()
        {
            var online = _service.Find<Online>(7);
            base.ViewBag.Last_Result = online.Last_Result;
            return View();
            
        }
    }
}