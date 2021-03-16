using _18bangMVC.Filter;
using _18bangMVC.Models;
using ProdServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Global;
using _18bangServices.ViewModel;
using _18bangMVC.Helper;

namespace _18bangMVC.Controllers
{
    public class RegisterController : BaseController
    {
        private UserService userService;
        public RegisterController()
        {
            userService = new UserService();
        }

        // GET: Register
        [ModelErrorTransferFilter]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult Index(RegisterModel model)
        {
            if (model.Captcha != Session[Keys.CAPTCHA].ToString())
            {
                return View(model);
            }

            if (userService.RGetByName(model.InviterName) == null)
            {
                ModelState.AddModelError(nameof(model.InviterName), "邀请人是不是填错啦");
                return View(model);
            }
            if (userService.RGetByName(model.InviterName).InviterCode!=model.InviterCode)
            {
                ModelState.AddModelError(nameof(model.InviterCode), "邀请码是不是填错啦");
                return View(model);
            }
            if (userService.RGetByName(model.Name) != null)
            {
                ModelState.AddModelError("Name", "*用户名不能重复");
                return View(model);
            }


            int userId = userService.Register(model);

            ///防止cookie伪造
            CookieHelper.addCookie(userId, model.Password.MD5Crypt());
            if (Request.QueryString==null)
            {
                return View("/Home");
            }

            return Redirect(Request.QueryString[Keys.Prepage]);

        }


      
    }
}