using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SV19T1021021.DomainModel;
namespace SV19T1021021.Web.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductDetailResult
    {
        /// <summary>
        /// Mặt hàng
        /// </summary>
        public Product ProductObj { get; set; }
        /// <summary>
        /// Danh sách ảnh
        /// </summary>
        public IList<ProductPhoto> ListPhoto { get; set; }
        /// <summary>
        /// Danh sach thuộc tính
        /// </summary>
        public IList<ProductAttribute> ListAttribute { get; set; }
    }
}