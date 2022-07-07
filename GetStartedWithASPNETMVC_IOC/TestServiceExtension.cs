using GetStartedWithASPNETMVC_IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity
{
    public static class TestServiceExtension
    {
        public static void AddTestServiceB(this IUnityContainer container)
        {
            container.RegisterType<ITestServiceA, TestServiceA>();
            container.RegisterType<ITestServiceB, TestServiceB>();
            container.RegisterType<ITestServiceC, TestServiceC>();
        }      
    }
}
