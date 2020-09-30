using System;
using System.Collections.Generic;
using NUnit.Framework;
using case1.Entities.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.TestData.srctest6
{
	public class Student1TestData
	{
		public const int Student1Count = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<Student1> CreateStudent1()
		{
			return new List<Student1>
			{
				CreateStudent11(),
				CreateStudent12(),
				CreateStudent13(),
			};
		}

		 public static Student1 CreateStudent11()
		{
			return new Student1
			{
					Id = 1, 
					Name = string.Empty, 
					Description = string.Empty, 
					user_id = 0.0d, 
					StudentName = string.Empty, 
					StudentNUM = 0, 
			};
		}
		 public static Student1 CreateStudent12()
		{
			return new Student1
			{
					Id = 2, 
					Name = string.Empty, 
					Description = string.Empty, 
					user_id = 0.0d, 
					StudentName = string.Empty, 
					StudentNUM = 0, 
			};
		}
		 public static Student1 CreateStudent13()
		{
			return new Student1
			{
					Id = 3, 
					Name = string.Empty, 
					Description = string.Empty, 
					user_id = 0.0d, 
					StudentName = string.Empty, 
					StudentNUM = 0, 
			};
		}
		public static void AssertAreEqual(Student1 expected, Student1 actual)
		{
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.user_id, actual.user_id);
			Assert.AreEqual(expected.StudentName, actual.StudentName);
			Assert.AreEqual(expected.StudentNUM, actual.StudentNUM);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
