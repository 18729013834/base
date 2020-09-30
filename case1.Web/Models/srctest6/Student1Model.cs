using System;
using System.Collections.Generic;
using System.Web.Mvc;
using case1.Entities.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Web.Models.srctest6
{
	public class Student1Model: CommonModel<Student1>
	{
		public double user_id {get; set;}
		public string StudentName {get; set;}
		public int StudentNUM {get; set;}

		public override void PopulateFrom(Student1 entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.user_id = entity.user_id;
			this.StudentName = entity.StudentName;
			this.StudentNUM = entity.StudentNUM;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Student1 entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.user_id = this.user_id;

			entity.StudentName = this.StudentName;

			entity.StudentNUM = this.StudentNUM;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
