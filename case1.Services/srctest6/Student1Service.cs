using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using case1.Entities.srctest6;
using MetaShare.Common.Core.Services;
using case1.Daos.Interfaces.srctest6;
using case1.Services.Interfaces.srctest6;

/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Services.srctest6
{
	public class Student1Service : Service<Student1>, IStudent1Service
	{
		public Student1Service() : base(typeof (IStudent1Dao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
