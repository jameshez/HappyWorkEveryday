using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// 自定义封装类(读取配置文件,执行sql语句)
    /// .net framework 4.0
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static DataSet GetDataSetExt(string sql)
        {
            DataSet dataSet = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn.connectionstring))
                {
                    connection.Open();
                    SqlCommand selectCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandText = sql
                    };
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch (Exception exception)
            {
                LogRunException.LogRunEx(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff") + "        " + exception.Message + ":sql语句执行异常(" + sql + ")\r\n");
            }
            return dataSet;
        }

        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="para">参数化查询</param>
        /// <returns></returns>
        public static DataSet GetDataSetExt(string sql, SqlParameter[] para)
        {
            DataSet dataSet = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn.connectionstring))
                {
                    connection.Open();
                    SqlCommand selectCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandText = sql
                    };
                    selectCommand.Parameters.AddRange(para);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch (Exception exception)
            {
                LogRunException.LogRunEx(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff") + "        " + exception.Message + ":sql语句执行异常(" + sql + "  ");
                foreach (SqlParameter parameter in para)
                {
                    LogRunException.LogRunEx(string.Concat(new object[] { parameter.ParameterName, ":", parameter.Value, "  " }));
                }
                LogRunException.LogRunEx("\r\n");
            }
            return dataSet;
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandParameters">参数化</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] commandParameters)
        {
            int ret = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn.connectionstring))
                {
                    connection.Open();
                    SqlCommand selectCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandText = sql
                    };
                    selectCommand.Parameters.AddRange(commandParameters);
                    ret = selectCommand.ExecuteNonQuery();
                    selectCommand.Parameters.Clear();
                }
            }
            catch (Exception exception)
            {
                LogRunException.LogRunEx(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff") + "        " + exception.Message + ":sql语句执行异常(" + sql + "  ");
                foreach (SqlParameter parameter in commandParameters)
                {
                    LogRunException.LogRunEx(string.Concat(new object[] { parameter.ParameterName, ":", parameter.Value, "  " }));
                }
                LogRunException.LogRunEx("\r\n");
            }
            return ret;
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            int ret = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn.connectionstring))
                {
                    connection.Open();
                    SqlCommand selectCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandText = sql
                    };
                    ret = selectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                LogRunException.LogRunEx(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff") + "        " + exception.Message + ":sql语句执行异常(" + sql + ")\r\n");
            }
            return ret;
        }

        /// <summary>
        /// 读取配置文件 
        /// </summary>
        public class Conn
        {
            public Conn(string key)
            {
                try
                {
                    connectionstring = ConfigurationManager.ConnectionStrings[key].ConnectionString;
                }
                catch (Exception)
                {
                    try
                    {
                        connectionstring = ConfigurationManager.AppSettings[key].ToString();
                    }
                    catch (Exception exception)
                    {
                        SqlHelper.LogRunException.LogRunEx(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff") + "        " + exception.Message + ":读取配置文件异常(connectionstring=" + connectionstring + ")\r\n");
                    }
                }
            }


            /// <summary>
            /// 数据库连接字符串
            /// </summary>
            public static string connectionstring
            {
                get;
                set;
            }
        }

        /// <summary>
        /// 运行异常(写)日志类 
        /// </summary>
        public class LogRunException
        {
            /// <summary>
            /// 写入异常信息
            /// </summary>
            /// <param name="content">异常信息</param>
            public static void LogRunEx(string content)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                if (Directory.Exists(baseDirectory + "LogRunEx"))
                {
                    using (StreamWriter writer = new StreamWriter(baseDirectory + @"LogRunEx\logRunEx_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", true))
                    {
                        writer.Write(content);
                        return;
                    }
                }
                Directory.CreateDirectory(baseDirectory + "LogRunEx");
            }
        }

        /// <summary>
        /// 参数化类
        /// </summary>
        public class Parameters
        {
            public static SqlParameter Parameter(string key, object val, ParameterDirection pd)
            {
                try
                {
                    return new SqlParameter(key, val) { Direction = pd };
                }
                catch (Exception exception)
                {
                    SqlHelper.LogRunException.LogRunEx(string.Concat(new object[] { DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff"), "        ", exception.Message, "：实例化sql参数异常(key=", key, ",value=", val, ")\r\n" }));
                }
                return null;
            }

            /// <summary>
            /// SqlParameter参数实例化 
            /// </summary>
            /// <param name="key">Ex:@param</param>
            /// <param name="val">参数值</param>
            /// <returns></returns>
            public static SqlParameter ParameterIn(string key, object val)
            {
                return Parameter(key, val, ParameterDirection.Input);
            }
        }
    }
}
