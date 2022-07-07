using GetStartedWithASPNETMVC_Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedWithASPNETMVC_Services
{
    public class OnlineService : BaseService, IOnlineService
    {
        public OnlineService(DbContext context) : base(context)
        {

        }
    }
}
