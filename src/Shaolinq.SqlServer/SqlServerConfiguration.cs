﻿// Copyright (c) 2007-2018 Thong Nguyen (tumtumtum@gmail.com)

using System.Collections.Generic;
using Shaolinq.Persistence;

namespace Shaolinq.SqlServer
{
	public class SqlServerConfiguration
	{
		public static DataAccessModelConfiguration Create(string databaseName, string serverName, string userName, string password, bool deleteDatabaseDropsTablesOnly = false)
		{
			return Create(databaseName, serverName, userName, password, null);
		}

		public static DataAccessModelConfiguration Create(string connectionString, bool deleteDatabaseDropsTablesOnly = false, bool multipleActiveResultsets = false)
		{
			return new DataAccessModelConfiguration
			{
				SqlDatabaseContextInfos = new List<SqlDatabaseContextInfo>
				{
					new SqlServerSqlDatabaseContextInfo()
					{
						ConnectionString = connectionString,
						DeleteDatabaseDropsTablesOnly = deleteDatabaseDropsTablesOnly,
						MultipleActiveResultSets = multipleActiveResultsets,
                        TrustedConnection = true
					}
				}
			}; 
		}

		public static DataAccessModelConfiguration Create(string databaseName, string serverName, string userName = null, string password = null, string categories = null, bool deleteDatabaseDropsTablesOnly = false, bool multipleActiveResultsets = false)
		{
			return new DataAccessModelConfiguration()
			{
				SqlDatabaseContextInfos = new List<SqlDatabaseContextInfo>
				{
					new SqlServerSqlDatabaseContextInfo
					{
						DatabaseName = databaseName,
						Categories = categories,
						ServerName = serverName,
						UserName = userName,
						Password = password,
						DeleteDatabaseDropsTablesOnly = deleteDatabaseDropsTablesOnly,
						MultipleActiveResultSets = multipleActiveResultsets
					},
				}
			};
		}
	}
}
