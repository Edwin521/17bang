using _18bangMVC.Filter;
using _18bangMVC.Helper;
using _18bangMVC.Models;
using _18bangServices.ViewModel;
using _18bangServices.ViewModel.Log;
using ProdServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class LogController : BaseController
    {
        private UserService userService;
        public LogController()
        {
            userService = new UserService();
        }

        // GET: Log
        [ModelErrorTransferFilter]
        public ActionResult On()
        {

            //if (TempData["errrorMessage"] != null)
            //{
            //    ModelState.Merge((TempData["errrorMessage"] as ModelStateDictionary));
            //} 

            //OnModel model = new OnModel
            //{
            //    Name = "LZB",
            //    Password = "1234",
            //    Captcha = "3452"
            //};


            //Session["user"] = new RegisterModel
            //{
            //    Name = "lzb",
            //};
            return View();



        }
        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult On(OnModel model )
        {
            if (model.Captcha!=Session[Keys.CAPTCHA].ToString())
            {
                return View(model);
            }

         
           OnModel result = userService.OGetByName(model.Name);
            if (result ==null)
            {
                ModelState.AddModelError(Keys.Name, "*输入的用户名不存在");
                return View();
            }
            if (result.Password!=model.Password)
            {
                ModelState.AddModelError(Keys.Password, "用户名或密码错误");
                return View();
            }
            //添加cookie
            CookieHelper.addCookie(result.Id, result.Password, result.RemberMe);
            if (Request.QueryString[Keys.Prepage]==null)
            {
                  return View("/Home");
            }
            return RedirectToAction(nameof(On));
        }




        public ActionResult Off() {
            ///退出登录，清除cookie
            HttpCookie cookie = HttpContext.Response.Cookies.Get(Keys.CookieName);
            cookie.Expires = DateTime.Now.AddDays(-30);

            return RedirectToAction(nameof(On));

        }
        [HttpPost]
        public ActionResult Off(OffModel model)
        {
            return View();

        }

    }
}