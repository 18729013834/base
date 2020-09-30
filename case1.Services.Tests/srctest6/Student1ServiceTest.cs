using System;
using System.Collections.Generic;
using NUnit.Framework;
using case1.Entities.srctest6;
using case1.TestData.srctest6;
using case1.Services.Tests.Common;
using case1.Services.Interfaces.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Services.Tests.srctest6
{

	[TestFixture]
	public class Student1ServiceTest : CommonServiceTest<Student1, IStudent1Service>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<Student1> items = this.Service.SelectAll();
			Assert.AreEqual(Student1TestData.Student1Count, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent11();

			List<Student1> find = this.Service.SelectBy(new Student1 {Name = itemTest.Name}, new List<string> {"Name"});
			Assert.IsNotNull(find);

			foreach (Student1 item in find)
			{
				Assert.AreEqual(itemTest.Name, item.Name);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent11();

			Student1 find = this.Service.SelectById(new Student1 {Id = itemTest.Id});
			Assert.IsNotNull(find);

			Student1TestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent12();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<Student1> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, Student1TestData.Student1Count - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			Student1 itemTest = new Student1
			{
				Name = string.Empty, 
				Description = string.Empty, 
				user_id = 0.0d, 
				StudentName = string.Empty, 
				StudentNUM = 0, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<Student1> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, Student1TestData.Student1Count + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent11();

			Student1 beforeUpdate = this.Service.SelectById(new Student1 {Id = itemTest.Id});
			beforeUpdate.Name = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			Student1 afterUpdate = this.Service.SelectById(new Student1 {Id = itemTest.Id});
			Student1TestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
