using _18bangMVC.Filter;
using _18bangMVC.Models;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class RegisterController : BaseController
    {
        public UserRepository userRepository;
        public RegisterController()
        {
            userRepository = new UserRepository();
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
            //    if (model.Captcha != Session[Keys.CAPTCHA].ToString())
            //    {
            //        return View(model);
            //    }
        
            if (userRepository.GetByName(model.InviterName) == null)
            {
                ModelState.AddModelError(nameof(model.InviterName), "邀请人是不是填错啦");
                return View(model);
            }
            if (userRepository.GetByName(model.InviterName).MyInviterCode!=model.InviterCode)
            {
                ModelState.AddModelError(nameof(model.InviterCode), "邀请码是不是填错啦");
                return View(model);
            }
            if (userRepository.GetByName(model.Name) != null)
            {
                ModelState.AddModelError("Name", "*用户名不能重复");
                return View(model);
            }


            User newUser = new User
            {
                Name = model.Name,
                Password = model.Password,
            };
          
            newUser.Register();

            int id = userRepository.Save(newUser);




            return View();

        }


        //    [HttpPost]
        //    public ActionResult Index(RegisterModel model)
        //    {
        //        //if (!ModelState.IsValid)
        //        //{
        //        //    return View();
        //        //}


        //        //RegisterService registerService = new RegisterService();
        //        #region 确保登录信息正确
        //        RegisterModel inviter = registerService.GetByName(model.InviterName);
        //        if (inviter == null)
        //        {
        //            ModelState.AddModelError(nameof(model.InviterName), "请检查邀请人是不是填错啦");
        //            return View(model);
        //        }
        //        if (inviter.InviterCode != model.InviterCode)
        //        {
        //            ModelState.AddModelError(nameof(model.InviterCode), "请检查邀请码填写是否正确");
        //            return View(model);
        //        }
        //        if (registerService.GetByName(model.Name) != null)
        //        {
        //            ModelState.AddModelError(nameof(model.Name), "这个名字已经被注册，请换个名字");
        //            return View(model);
        //        }

        //        #endregion

        //        int registerId = registerService.Add(new RegisterModel
        //        {
        //            InviterName = model.InviterName,
        //            InviterCode = model.InviterCode,
        //            Name = model.Name,
        //            Password = model.Password
        //        });
        //        return Redirect(Request.QueryString["prepage"]);
        //    }

    }
}