using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Areas.UserManagerArea
{
    public class UserManagerAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserManagerArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UserManagerArea_default",
                "UserManagerArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}