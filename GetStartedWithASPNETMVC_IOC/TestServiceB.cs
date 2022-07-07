using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedWithASPNETMVC_IOC
{
    internal class TestServiceB:ITestServiceB
    {
        public void Print()
        {
            Console.WriteLine(this.GetType().FullName);
        }
    }
}
