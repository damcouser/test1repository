using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data.Connection
{
	public static class Database
	{
		internal static SqlConnection Connect()
		{
			return new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDBv11"].ConnectionString);
		}

		public static SqlConnection Connect(String connectionString)
		{
			return new SqlConnection(connectionString);
		}

		public static SqlCommand Command(String query, SqlConnection connection, Boolean openConnection = true)
		{
			if (connection.State != ConnectionState.Open && openConnection) connection.Open();
			return new SqlCommand(query, connection);
		}

		public static T Get<T>(this SqlDataReader reader, String name)
		{
			return (T)(Object)reader.GetValue(reader.GetOrdinal(name));
		}

		public static Int32 GetInt32(this SqlDataReader reader, String name)
		{
			return reader.GetInt32(reader.GetOrdinal(name));
		}

		public static Guid GetGuid(this SqlDataReader reader, String name)
		{
			return reader.GetGuid(reader.GetOrdinal(name));
		}

		public static DateTime GetDateTime(this SqlDataReader reader, String name)
		{
			return reader.GetDateTime(reader.GetOrdinal(name));
		}

		public static String GetString(this SqlDataReader reader, String name)
		{
			return reader.GetString(reader.GetOrdinal(name));
		}
	}
}
