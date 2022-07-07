using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace GetStartedWithASPNETMVC_IOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            // 注入TestServiceA、TestServiceB、TestServiceC
            container.AddTestServiceB();
            var testServiceA = container.Resolve<ITestServiceA>();
            var testServiceB = container.Resolve<ITestServiceB>();
            var testServiceC = container.Resolve<ITestServiceC>();
            testServiceA.Print();
            testServiceB.Print();
            testServiceC.Print();
            Console.ReadLine();
        }
    }
}
