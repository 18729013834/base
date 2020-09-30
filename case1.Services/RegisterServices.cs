using MetaShare.Common.Core.CommonService;
using case1.Services.Interfaces.srctest6;
using case1.Services.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IStudent1Service), new Student1Service(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
