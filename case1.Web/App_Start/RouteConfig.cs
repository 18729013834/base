using System.Web.Mvc;
using System.Web.Routing;/*add customized code between this region*/
/*add customized code between this region*/


namespace case1.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",defaults: new { controller = "Student1", action = "Index", id = UrlParameter.Optional },
				namespaces:new[]  {"case1.Web.Controllers.srctest6"});
				/*add customized code between this region*/
				/*add customized code between this region*/
				
        }
    }
}