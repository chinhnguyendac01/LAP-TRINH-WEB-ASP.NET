using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SV19T1021021.DataLayer.SQL_Server
{

    /// <summary>
    /// Lớp cơ sở cho các lớp xử lý dữ liệu trên SQL Server
    /// </summary>
    public abstract class _BaseDAL
    {
        /// <summary>
        /// chuỗi tham số kết nối CSDL SQLServer
        /// </summary>
        protected string _connectionString;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="_connectionString"></param>
        public _BaseDAL(string connectionString)
        {
            _connectionString = connectionString;
        }
        /// <summary>
        /// Tạo và mở kết nổi trên CSDL
        /// </summary>
        /// <returns></returns>
        protected SqlConnection OpenConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = _connectionString;
            cn.Open();
            return cn;
        }
    }
}
