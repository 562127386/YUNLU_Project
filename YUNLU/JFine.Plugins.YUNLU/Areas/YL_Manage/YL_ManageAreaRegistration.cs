using System.Web.Mvc;

namespace JFine.Web.Areas.Portal
{
    public class YL_ManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Portal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "YL_Manage_default",
                "YL_Manage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "JFine.Plugins.YUNLU.Areas.YL_Manage.Controllers" }
            );
        }
    }
}