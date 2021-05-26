using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseHelper
{
    public class TestDatabase<TConnection> where TConnection : IDbConnection, new()
    {
        private TConnection _connection;

        public TestDatabase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; protected init; }

        public TConnection GetConnection()
        {
            _connection = new TConnection();
            _connection.ConnectionString = ConnectionString;
            return _connection;
        }
    }

    public class SqlTestDatabase : TestDatabase<SqlConnection>
    {
        public SqlTestDatabase(string connectionString) : base(connectionString)
        {

        }
    }
}
