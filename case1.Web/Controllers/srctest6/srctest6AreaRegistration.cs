using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Web.Controllers.srctest6
{
	public class srctest6AreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			"srctest6",
			"srctest6/{controller}/{action}/{id}",
			new {action = "Index", id = UrlParameter.Optional},
			namespaces:new[]  {"case1.Web.Controllers.srctest6"});
		}

		public override string AreaName
		{
			get { return "srctest6"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
