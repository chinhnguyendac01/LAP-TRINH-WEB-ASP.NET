﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SV19T1021021.DomainModel; 
namespace SV19T1021021.Web.Models
{
    /// <summary>
    /// Kết quả tìm kiếm, phân trang của loại hàng
    /// </summary>
    public class ProductPaginationSearchResult : BasePaginationResult
    {

        /// <summary>
        /// Loại hàng
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// Mặt hàng
        /// </summary>
        public int SupplierID { get; set; }
    }
}