using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV19T1021021.Web.Models
{
    /// <summary>
    /// Dữ liệu đầu vào cho tìm kiếm, phân trang
    /// </summary>
    public class PaginationSearchResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SearchValue { get; set; }

    }
}
