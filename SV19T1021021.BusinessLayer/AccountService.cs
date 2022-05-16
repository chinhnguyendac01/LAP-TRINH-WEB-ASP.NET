using SV19T1021021.DataLayer;
using SV19T1021021.DomainModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SV19T1021021.BusinessLayer
{
    public class AccountService
    {
        private static IAccountDAL accountDB;
        /// <summary>
        /// Ctor
        /// </summary>
        static AccountService()
        {
            string provider = ConfigurationManager.ConnectionStrings["DB"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            switch (provider)
            {
                case "SQLServer":
                    accountDB = new DataLayer.SQL_Server.AccountDAL(connectionString);
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool LoginSuccess(Account data)
        {
            Account validate = accountDB.Get(data.Email);
            if (validate == null || validate.Password != data.Password)
                return false;
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool ChangePassword(Account data)
        {
            return accountDB.Update(data);
        }
    }
}
