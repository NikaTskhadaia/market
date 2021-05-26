using DatabaseHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Market.Repository.Extensions
{
    public static class ExtensionMethods
    {
        public static IEnumerable<string> GetProcedureParams(this string procedureName, Database<SqlConnection> database)
        {
            SqlParameter sqlParameter = new() { ParameterName = "@Name", Value = procedureName };

            var table = database.GetTable("GetParams_SP", CommandType.StoredProcedure, sqlParameter);

            return table.AsEnumerable().Select(row => row[0].ToString());
        }

        public static IEnumerable<SqlParameter> ToSqlParams<T>(this IEnumerable<string> procedureParams, T model)
        {
            var type = model.GetType();
            foreach (var item in procedureParams)
            {
                var modelProperty = type.GetProperty(item.Replace("@", ""));
                yield return new SqlParameter { ParameterName = item, Value = modelProperty.GetValue(model) };
            }
        }

        public static T MapToModel<T>(this DataRow dataRow) where T : new()
        {
            T obj = new();
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType.IsInterface)
                {
                    continue;
                }
                var value = dataRow[property.Name];
                if (value == DBNull.Value)
                {
                    continue;
                }
                property.SetValue(obj, value);
            }
            return obj;
        }
    }
}