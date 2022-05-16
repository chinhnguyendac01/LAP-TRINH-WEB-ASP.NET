using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV19T1021021.DomainModel
{
    /// <summary>
    /// khách hàng
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// Tên khách hàng
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// Tên dao dịch của khách hàng
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        ///  Địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Thành phố
        /// </summary>
        public string City { get; set; }
        /// <summary>
        ///  Mã bưu chính
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Quốc gia
        /// </summary>
        public string Country { get; set; }

    }
}
