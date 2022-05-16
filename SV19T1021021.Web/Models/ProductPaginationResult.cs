using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SV19T1021021.DomainModel; 

namespace SV19T1021021.Web.Models
{
    /// <summary>
    /// Kết quả tìm kiếm, phân trang của loại hàng
    /// </summary>
    public class ProductPaginationResult : BasePaginationResult
    {
        /// <summary>
        /// Danh sách mặt hàng phân trang
        /// </summary>
        public IList<Product> Data { get; set; }
        /// <summary>
        /// Mã mặt hàng
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// Mã nhà cung cấp
        /// </summary>
        public int SupplierID { get; set; }
    }
}