using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV19T1021021.DomainModel
{
    /// <summary>
    /// Tài khoản
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Tài khoản đăng nhập
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string Password { get; set; }
    }
}
