using Logic.Data.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data
{
	public static class User
	{
		// Password should be encrypted?
		public static Int32 Login(String username, String password)
		{
			using (var connection = Database.Connect())
			using (var command = Database.Command(@"EXEC [dbo].[Login] @Username, @Password;", connection))
			{
				command.Parameters.AddWithValue("@Username", username);
				command.Parameters.AddWithValue("@Password", password);

				var result = command.ExecuteScalar();
				if (result != null)
					return (Int32)result;
				return -1; // Failed login
			}
		}
	}
}
