using GetStartedWithASPNETMVC_Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedWithASPNETMVC_Services
{
    public class CustomService : BaseService, ICustomService
    {
        public CustomService(DbContext context) : base(context)
        {

        }
    }
}
