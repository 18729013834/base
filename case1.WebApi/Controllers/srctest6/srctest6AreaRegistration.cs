using System.Web.Http;
using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.WebApi.Controllers.srctest6
{
	public class srctest6AreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.Routes.MapHttpRoute(
			name:"srctest6",
			routeTemplate:"srctest6/{controller}/{action}/{id}",
			defaults:new 
			{
				area = "srctest6",
				action = "Index",
				id = UrlParameter.Optional,
				namespaceName = new[] {"case1.WebApi.Controllers.srctest6"}
			});
		}

		public override string AreaName
		{
			get { return "srctest6"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
