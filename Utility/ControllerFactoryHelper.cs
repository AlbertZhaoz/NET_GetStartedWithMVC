using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Unity;

namespace GetStartedWithASPNETMVC.Utility
{
    public class ControllerFactoryHelper:DefaultControllerFactory
    {
        /// <summary>
        /// 创建控制器
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            return base.CreateController(requestContext, controllerName);
        }

        /// <summary>
        /// 获取控制器实例
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerType"></param>
        /// <returns></returns>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            object oInstance = DIFactoryHelper.GetContainer().Resolve(controllerType);
            return (IController)oInstance;
        }
    }
}