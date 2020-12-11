using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.DbHelp
{
    public class DbHelper
    {
            //封装连接字符串
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog=18bang;Integrated Security=True;";

        private DbConnection connection;
        public DbHelper()
        {
            connection = new SqlConnection(connectionString);
        }

        public DbConnection Connection
        {
            get => connection;//只读
        }

        /// <summary>
        /// 执行sql command,封装所有非查询类
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parametersName"></param>
        public void ExcuteNonQuery(string cmdText, params SqlParameter[] parametersName)
        {
            DbConnection connection = Connection;
            new DbHelper().ExcuteNonQuery(cmdText, connection, parametersName);
        }

        public void ExcuteNonQuery(string cmdText, DbConnection connection, params SqlParameter[] parameterName)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            using (DbCommand cmd = new SqlCommand(cmdText, (SqlConnection)connection))
            {
                cmd.Parameters.AddRange(parameterName);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 执行sql命令，并且返回插入的id.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parametersName"></param>
        /// <returns></returns>
        public int Insert(string cmdText, params SqlParameter[] parametersName)
        {
            return new DbHelper().Insert(Connection, cmdText, parametersName);
        }


        public int Insert(DbConnection connection, string cmdText, params SqlParameter[] parameterName)
        {
            cmdText = cmdText + " Set @NewId = @@Identity ";
            DbCommand cmd = new SqlCommand(cmdText, (SqlConnection)connection);
            SqlParameter pId = new SqlParameter("@NewId", System.Data.SqlDbType.Int)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            cmd.Parameters.Add(pId);
            cmd.Parameters.AddRange(parameterName);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(pId.Value);
        }

        /// <summary>
        /// 返回字符串标量（scalar）
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parameterName"></param>
        /// <returns></returns>
        public string ExcuteScalar(string cmdText, SqlParameter parameterName)
        {
            DbConnection connection = Connection;
            return new DbHelper().ExcuteScalar(cmdText, parameterName, connection);
        }
        public string ExcuteScalar(string cmdText, SqlParameter parameterName, DbConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            DbCommand cmd = new SqlCommand(cmdText, (SqlConnection)connection);
            cmd.Parameters.Add(parameterName);
            object reader = cmd.ExecuteScalar();

            if (reader == DBNull.Value)
            {
                return null;
            }//else nothing.
            if (string.IsNullOrEmpty(reader.ToString()))
            {
                return null;
            }//else nothing.
            return reader.ToString();
        }


        public DbDataReader ExcuteReader(string cmdText, DbConnection connection)
        {
            return new DbHelper().ExcuteReader(cmdText, connection, new SqlParameter[] { });
        }

        public DbDataReader ExcuteReader(string cmdText, DbConnection connection, params SqlParameter[] parameterName)
        {
            DbCommand cmd = new SqlCommand(cmdText, (SqlConnection)connection);
            cmd.Parameters.AddRange(parameterName);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            DbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

    }
}
