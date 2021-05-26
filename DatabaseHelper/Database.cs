using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseHelper
{
    //შეეცადეთ გადააკეთოთ კლასი ისე, რომ არ იყოს დამოკიდებული მხოლოდ Sql Server-ზე
    public class Database<TConnection> : IDisposable, IDatabase where TConnection : IDbConnection, new()
    {
        private readonly bool _useSingleton;
        private TConnection _connection;
        private IDbTransaction _transaction;

        public Database(string connectionString, bool useSingleton = true)
        {
            ConnectionString = connectionString;
            _useSingleton = useSingleton;
            GetConnection();
        }

        public string ConnectionString { get; protected init; }

        public IDbConnection GetConnection()
        {
            _connection = new TConnection
            {
                ConnectionString = ConnectionString
            };
            return _connection;
        }

        public void BeginTransaction()
        {
            if (!_useSingleton)
            {
                throw new Exception("Transaction is supported only in single mode.");
            }
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            _transaction = _connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (_transaction == null)
            {
                throw new Exception("There is no active transaction");
            }
            _transaction.Commit();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            if (_transaction == null)
            {
                throw new Exception("There is no active transaction");
            }
            _transaction.Rollback();
            _transaction = null;
        }

        public IDbCommand GetCommand(string commandText, CommandType commandType, params IDataParameter[] parameters)
        {
            IDbCommand command = _connection.CreateCommand();
            command.CommandType = commandType;
            command.CommandText = commandText;
            foreach (IDataParameter item in parameters)
            {
                command.Parameters.Add(item);
            }
            if (_transaction != null)
            {
                command.Transaction = _transaction;
            }
            return command;
        }

        public IDbCommand GetCommand(string commandText, params IDataParameter[] parameters)
        {
            return GetCommand(commandText, CommandType.Text, parameters);
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, params IDataParameter[] parameters)
        {
            var cmd = GetCommand(commandText, commandType, parameters);
            try
            {
                if (_transaction == null)
                {
                    cmd.Connection.Open();
                }
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                if (_transaction == null)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public int ExecuteNonQuery(string commandText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public object ExecuteScalar(string commandText, CommandType commandType, params IDataParameter[] parameters)
        {
            var cmd = GetCommand(commandText, commandType, parameters);
            try
            {
                if (_transaction == null)
                {
                    cmd.Connection.Open();
                }
                return cmd.ExecuteScalar();
            }
            finally
            {
                if (_transaction == null)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public object ExecuteScalar(string commandText, params IDataParameter[] parameters)
        {
            return ExecuteScalar(commandText, CommandType.Text, parameters);
        }

        public IDataReader ExecuteReader(string commandText, CommandType commandType, params IDataParameter[] parameters)
        {
            var cmd = GetCommand(commandText, commandType, parameters);
            if (_transaction == null)
            {
                cmd.Connection.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            return cmd.ExecuteReader();
        }

        public IDataReader ExecuteReader(string commandText, params IDataParameter[] parameters)
        {
            return ExecuteReader(commandText, CommandType.Text, parameters);
        }

        public DataTable GetTable(string commandText, CommandType commandType, params IDataParameter[] parameters)
        {
            var reader = ExecuteReader(commandText, commandType, parameters);
            var table = new DataTable();
            table.Load(reader);
            if (_transaction == null)
            {
                reader.Close();
            }
            return table;            
        }

        public DataTable GetTable(string commandText, params IDataParameter[] parameters)
        {
            return GetTable(commandText, CommandType.Text, parameters);
        }

        public void Dispose()
        {
            if (_useSingleton && _connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}