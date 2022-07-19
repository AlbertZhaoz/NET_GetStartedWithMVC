using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Utility
{
    public class CustomCompressionActionFilterAttribute:ActionFilterAttribute
    {
        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 判断客户端和服务端是否有相同的压缩规则
            var request = filterContext.HttpContext.Request;
            var response = filterContext.HttpContext.Response;
            var acceptEncoding = request.Headers["Accept-Encoding"];//检测支持格式

            if (!string.IsNullOrWhiteSpace(acceptEncoding) && acceptEncoding.ToUpper().Contains("GZIP")) //如果包含说明浏览器已经声明了支持GZIP格式压缩
            {
                response.AddHeader("Content-Encoding", "gzip");//响应头指定类型
                response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);//压缩类型指定
            }

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}