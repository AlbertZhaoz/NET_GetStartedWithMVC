using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetStartedWithASPNETMVC.Utility.Filter
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CsutomAllowAnonymousAttribute: Attribute
    {
    }
}