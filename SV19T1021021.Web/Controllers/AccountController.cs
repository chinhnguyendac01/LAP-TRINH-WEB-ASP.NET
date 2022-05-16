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
    public class AccountController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View(new Account());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Account model)
        {
            if (string.IsNullOrWhiteSpace(model.Email))
                ModelState.AddModelError("Email", "Email hiện trống");
            if (string.IsNullOrWhiteSpace(model.Password))
                ModelState.AddModelError("Password", "Password hiện trống");
            if (ModelState.IsValid)
                if (AccountService.LoginSuccess(model))
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("Failed", "Email hoặc password không đúng");
            return View(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}
