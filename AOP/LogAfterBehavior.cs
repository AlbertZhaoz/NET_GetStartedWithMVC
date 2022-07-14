using GetStartedWithASPNETMVC.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace GetStartedWithASPNETMVC.AOP
{
    public class LogAfterBehavior : IInterceptionBehavior
    {
        //private bool willExecute;

        //public bool WillExecute
        //{
        //    get { return willExecute; }
        //    set { willExecute = true; }
        //}

        public bool WillExecute => true;

        //在执行数据库查询之后，读取一些文件内容，记录到数据库中。
        private readonly Logger logger = new Logger(typeof(LogAfterBehavior));


        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            // 原先方法之后执行
            {
                Console.WriteLine($"{input.MethodBase.Name} 执行之执行前....");
            }

            // 执行原先方法
            IMethodReturn methodReturn = getNext()(input, getNext);

            // 原先方法之前执行
            // 先从App_Data中读取文本，然后写入到sql数据库中
            {
                var sqlContent = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data\\CreateErrorLog.md"));
                logger.Info($"在执行{input.MethodBase.Name}方法之前执行了读取文本操作，并记录到数据库中");
                logger.Debug(sqlContent);
            }     

            return methodReturn;
        }
    }
}