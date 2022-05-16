using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SV19T1021021.BusinessLayer;
using SV19T1021021.DomainModel;


namespace SV19T1021021.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    [RoutePrefix("category")]
    public class CategoryController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            Models.PaginationSearchResult model = Session["CATEGORY_SEARCH"] as Models.PaginationSearchResult;
            if (model == null)
            {
                model = new Models.PaginationSearchResult()
                {
                    Page = 1,
                    PageSize = 10,
                    SearchValue = ""
                };
            }
            return View(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ActionResult Search(Models.PaginationSearchResult input)
        {
            int rowCount = 0;
            var data = CommonDataService.ListOfCategories(input.Page, input.PageSize, input.SearchValue, out rowCount);
            Models.CategoryPaginationResult model = new Models.CategoryPaginationResult()
            {
                Page = input.Page,
                PageSize = input.PageSize,
                SearchValue = input.SearchValue,
                RowCount = rowCount,
                Data = data
            };
            Session["CATEGORY_SEARCH"] = input;
            return View(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            Category model = new Category()
            {
                CategoryId = 0
            };
            ViewBag.Title = "Bổ sung loại hàng";
            return View(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        [Route("edit/{categoryID}")]
        public ActionResult Edit(int categoryID)
        {
            Category model = CommonDataService.GetCategory(categoryID);
            if (model == null)
                return RedirectToAction("Index");

            ViewBag.Title = "Thay đổi thông tin loại hàng";
            return View("Create", model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(Category model)
        {
            //kiểm tra dữ liệu đầu vào k dc null
            if (string.IsNullOrWhiteSpace(model.CategoryName))
                ModelState.AddModelError("CategoryName", "Tên khách hàng không được để trống");
            if (string.IsNullOrWhiteSpace(model.Description))
                model.Description = "";

            if (!ModelState.IsValid)
            {
                ViewBag.Title = model.CategoryId == 0 ? "Bổ sung loại hàng" : "Thay đổi thông tin";
                return View("Create", model);
            }

            //lưu dữ liệu
            if (model.CategoryId == 0)
            {
                CommonDataService.AddCategory(model);
                Session["CATEGORY_SEARCH"] = new Models.PaginationSearchResult()
                {
                    Page = 1,
                    PageSize = 10,
                    SearchValue = model.CategoryName
                };
                return RedirectToAction("Index");
            }
            else
            {
                CommonDataService.UpdateCategory(model);
                return RedirectToAction("Index");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        [Route("delete/{categoryID}")]
        public ActionResult Delete(int categoryID)
        {
            if (Request.HttpMethod == "POST")
            {
                CommonDataService.DeleteCategory(categoryID);
                return RedirectToAction("Index");
            }
            var model = CommonDataService.GetCategory(categoryID);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}