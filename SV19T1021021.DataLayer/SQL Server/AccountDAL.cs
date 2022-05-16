using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SV19T1021021.DomainModel;
using System.Data;
using System.Data.SqlClient;

namespace SV19T1021021.DataLayer.SQL_Server
{
    public class AccountDAL : _BaseDAL, IAccountDAL
    {
        public AccountDAL(string connectionString) : base(connectionString)
        {
        }

        public Account Get(string email)
        {
            Account result = null;
            using (SqlConnection cn = OpenConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"SELECT Email, Password
                                    FROM Employees
                                    WHERE Email = @email";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@email", email);

                var dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dbReader.Read())
                {
                    result = new Account()
                    {
                        Email = Convert.ToString(dbReader["Email"]),
                        Password = Convert.ToString(dbReader["Password"])
                    };
                }
                dbReader.Close();
                cn.Close();
            }
            return result;
        }

        public bool Update(Account data)
        {
            bool result = false;
            using (SqlConnection cn = OpenConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"UPDATE Employees
                                    SET Password = @password
                                    WHERE Email= @email";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@Email", data.Email);
                cmd.Parameters.AddWithValue("@Password", data.Password);

                result = cmd.ExecuteNonQuery() > 0;

                cn.Close();
            }
            return result;
        }
    }
}
