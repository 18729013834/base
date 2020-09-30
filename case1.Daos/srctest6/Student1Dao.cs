using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using case1.Daos.Interfaces.srctest6;
using case1.Entities.srctest6;
/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Daos.srctest6
{
	public class Student1Dao : CommonObjectDao<Student1>, IStudent1Dao
	{
		public class Student1SqlBuilder : ObjectSqlBuilder
		{
			public Student1SqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Student1")
			{
				this.SqlInsert = "INSERT INTO Student1 (user_id,StudentName,StudentNUM," + this.SqlBaseFieldInsertFront + ") VALUES (@user_id,@StudentName,@StudentNUM," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Student1 SET user_id=@user_id,StudentName=@StudentName,StudentNUM=@StudentNUM," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class Student1ResultHandler : CommonObjectResultHandler<Student1>
		{
			public override void GetColumnValues(IDataReader reader, Student1 item)
			{
				base.GetColumnValues(reader, item);
				int ordinaluser_id = reader.GetOrdinal("user_id");
				item.user_id =  reader.IsDBNull(ordinaluser_id) ? 0 : reader.GetDouble(ordinaluser_id);
				int ordinalStudentName = reader.GetOrdinal("StudentName");
				item.StudentName = reader.IsDBNull(ordinalStudentName) ? null : reader.GetString(ordinalStudentName);
				int ordinalStudentNUM = reader.GetOrdinal("StudentNUM");
				item.StudentNUM = reader.IsDBNull(ordinalStudentNUM) ? 0 : reader.GetInt32(ordinalStudentNUM);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Student1 item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "user_id", item.user_id);
				context.AddParameter(command, "StudentName", item.StudentName ?? (object) DBNull.Value);
				context.AddParameter(command, "StudentNUM", item.StudentNUM);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public Student1Dao(SqlDialect sqlDialect) : base(new Student1SqlBuilder(sqlDialect), new Student1ResultHandler())
		{
		}

		public Student1Dao(SqlDialect sqlDialect, string schemaConnectionString) : base(new Student1SqlBuilder(sqlDialect), new Student1ResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
