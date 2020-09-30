using MetaShare.Common.Core.Daos;
using case1.Entities.srctest6;
using case1.Daos.Interfaces.srctest6;
using case1.TestData.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Daos.Mocks.srctest6
{
	public class Student1DaoMock : MockDao<Student1>, IStudent1Dao
	{
		public Student1DaoMock() : base(Student1TestData.CreateStudent1())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
