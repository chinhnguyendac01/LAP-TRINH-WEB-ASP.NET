using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV19T1021021.DataLayer
{
    public interface IProductDetailDAL<T> where T : class
    {
        /// <summary>
        /// Tìm kiếm, lấy danh sách
        /// </summary>
        /// <param name="productID">Mã mặt hàng</param>
        /// <returns></returns>
        IList<T> List(int productID = 0);
        /// <summary>
        /// Đếm số dòng dữ liệu trả về thoả
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        int Count(int productID = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(T data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(T data);
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
