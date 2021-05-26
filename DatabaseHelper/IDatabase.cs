using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHelper
{
    interface ITransaction
    {
        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }

    public interface IDatabase
    {
        IDbConnection GetConnection();

        IDbCommand GetCommand(string commandText, CommandType commandType, params IDataParameter[] parameters);

        IDbCommand GetCommand(string commandText, params IDataParameter[] parameters);

        int ExecuteNonQuery(string commandText, CommandType commandType, params IDataParameter[] parameters);

        int ExecuteNonQuery(string commandText, params IDataParameter[] parameters);

        object ExecuteScalar(string commandText, CommandType commandType, params IDataParameter[] parameters);

        object ExecuteScalar(string commandText, params IDataParameter[] parameters);

        IDataReader ExecuteReader(string commandText, CommandType commandType, params IDataParameter[] parameters);

        IDataReader ExecuteReader(string commandText, params IDataParameter[] parameters);
    }

    interface ITransactionalDatabase : ITransaction, IDatabase
    {

    }
}
