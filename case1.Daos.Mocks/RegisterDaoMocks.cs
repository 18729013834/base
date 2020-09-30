using MetaShare.Common.Core.Daos;
using case1.Daos.Interfaces.srctest6;
using case1.Daos.Mocks.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(IStudent1Dao), new Student1DaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
