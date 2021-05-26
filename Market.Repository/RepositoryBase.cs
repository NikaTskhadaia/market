using DatabaseHelper;
using Market.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Market.Repository
{
    public abstract class RepositoryBase<T> where T : new()
    {
        protected readonly Database<SqlConnection> _database;
        protected readonly string _typeName;

        internal static string ConnectionString { get; private set; }

        public RepositoryBase(string connectionString)
        {
            _database = new Database<SqlConnection>(connectionString);
            _typeName = typeof(T).Name;
            ConnectionString = connectionString;
        }

        public virtual T Get(int id)
        {
            SqlParameter sqlParameter = new() { ParameterName = "@Id", SqlDbType = SqlDbType.Int, Value = id };
            DataTable dataTable = _database.GetTable($"Select{_typeName}_SP", CommandType.StoredProcedure, sqlParameter);

            T obj = dataTable.Rows[0].MapToModel<T>();

            return obj;
        }

        public IEnumerable<T> Select(Predicate<T> predicate)
        {
            List<T> list = new();
            var table = _database.GetTable($"SelectAll{_typeName}_SP");

            foreach (DataRow row in table.Rows)
            {
                T obj = row.MapToModel<T>();

                if (predicate(obj))
                {
                    list.Add(obj);
                }
            }
            return list;
        }

        public IEnumerable<T> Select()
        {
            return Select(x => true);
        }

        public int Insert(T model)
        {
            string procedureName = $"Insert{_typeName}_SP";

            var procedureParams = procedureName.GetProcedureParams(_database).ToSqlParams(model);

            return _database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, procedureParams.ToArray());
        }

        public void Update(T model)
        {
            string procedureName = $"Update{_typeName}_SP";

            var procedureParams = procedureName.GetProcedureParams(_database).ToSqlParams(model);

            _database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, procedureParams.ToArray());
        }

        public void Delete(int id)
        {
            SqlParameter sqlParameter = new() { ParameterName = "@Id", SqlDbType = SqlDbType.Int, Value = id };

            _database.ExecuteNonQuery($"Delete{_typeName}_SP", CommandType.StoredProcedure, sqlParameter);
        }
    }
}
