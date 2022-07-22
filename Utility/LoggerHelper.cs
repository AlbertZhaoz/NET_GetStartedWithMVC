using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GetStartedWithASPNETMVC.Utility
{
    public class LoggerHelper
    {
        private ILog loger = null;
        /// <summary>
        /// 静态构造函数（整个进程只执行一次-读取配置文件）
        /// </summary>
        static LoggerHelper()
        {
            XmlConfigurator.Configure(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\log4net.config")));
            ILog Log = LogManager.GetLogger(typeof(LoggerHelper));
            Log.Info("系统初始化Logger模块");
        }

        public LoggerHelper(Type type)
        {
            loger = LogManager.GetLogger(type);
        }

        public void Error(string msg = "出现异常", Exception ex = null) 
        {
            Console.WriteLine(msg);
            loger.Error(msg, ex);
        }

        public void Warn(string msg)
        {
            Console.WriteLine(msg);
            loger.Warn(msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine(msg);
            loger.Info(msg);
        }
        public void Debug(string msg)
        {
            Console.WriteLine(msg);
            loger.Debug(msg);
        }



    }
}