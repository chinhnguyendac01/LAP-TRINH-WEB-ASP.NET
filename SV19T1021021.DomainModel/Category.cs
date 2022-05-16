using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV19T1021021.DomainModel
{
    /// <summary>
    /// loai hang
    /// </summary>
    public class Category
    {
        /// <summary>
        /// MA LOAI HANG
        /// </summary>
        public int CategoryId { get; set; }
           /// <summary>
        /// TEN LOAI HANG
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// mo ta ve loai hang
        /// </summary>
        public string Description { get; set; }

    }
}
