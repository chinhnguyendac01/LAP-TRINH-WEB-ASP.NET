using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SV19T1021021.DomainModel;

namespace SV19T1021021.DataLayer
{
    public interface IProductDAL
    {
        /// <summary>
        /// Tìm kiếm, lấy danh sách
        /// </summary>
        /// <param name="productID">Mã mặt hàng</param>
        /// <returns></returns>
        IList<Product> List(int page = 1, int pageSize = 0, string searchValue = "", int categoryID = 0, int supplierID = 0);
        /// <summary>
        /// Đếm số dòng dữ liệu trả về thoả
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        int Count(string searchValue = "", int categoryID = 0, int supplierID = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product Get(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Product data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Product data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool InUsed(int id);
    }
}
