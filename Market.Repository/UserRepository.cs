using Market.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Market.Repository.Extensions;

namespace Market.Repository
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(string connectionString) :
            base(connectionString)
        {
        }

        public int Login(string username, string password)
        {
            SqlParameter[] parameters = {
                new SqlParameter { ParameterName = "@Username", SqlDbType = SqlDbType.NVarChar, Value = username },
                new SqlParameter { ParameterName = "@Password", SqlDbType = SqlDbType.VarChar, Value = password }
            };

            return (int)_database.ExecuteScalar("LoginUser_SP", CommandType.StoredProcedure, parameters);
        }
    }
}