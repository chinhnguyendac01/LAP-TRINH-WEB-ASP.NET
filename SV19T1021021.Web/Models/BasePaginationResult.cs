using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV19T1021021.Web.Models
{
    public abstract class BasePaginationResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public int RowCount { get; set; }
        public int PageCount 
        {
            get
            {
                if (PageSize == 0)
                    return 1;
                int p = RowCount / PageSize;
                if (RowCount % PageSize > 0)
                    p += 1;
                 return p;

            }
        }
        

    }
}