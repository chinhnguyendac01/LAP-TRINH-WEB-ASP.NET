    using SV19T1021021.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SV19T1021021.DataLayer.SQL_Server
{
    /// <summary>
    /// 
    /// </summary>
    public class CountryDAL : _BaseDAL, ICommonDAL<Country>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="connectionString"></param>
        public CountryDAL(string connectionString) : base(connectionString)
        {
        }

        public int Add(Country data)
        {
            throw new NotImplementedException();
        }

        public int Count(string searchValue = "")
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Country Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool InUsed(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Truy vấn SQL trả về dòng dữ liệu chứa danh sách các quốc gia
        /// </summary>
        /// <returns></returns>
        public IList<Country> List(int page = 1, int pageSize = 0, string searchValue = "")
        {

            List<Country> data = new List<Country>();

            using (SqlConnection cn = OpenConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Countries";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

                var dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dbReader.Read())
                {
                    data.Add(new Country()
                    {
                        CountryName = Convert.ToString(dbReader["CountryName"])
                    });
                }
                dbReader.Close();
                cn.Close();
            }
            return data;
        }

        public bool Update(Country data)
        {
            throw new NotImplementedException();
        }
    }
}
