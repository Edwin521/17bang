using _18bangMVC.Filter;
using _18bangServices.ViewModel.Email;
using _18bangServices.ViewModel.Password;
using Global;
using ProdServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class PasswordController : BaseController
    {
        private PasswordService passwordService;
        public PasswordController()
        {
            passwordService = new PasswordService();
        }
        #region ForgetPassword
        [ModelErrorTransferFilter]
        public ActionResult Forget()
        {
            return View();
        }
        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult Forget(ForgetModel model)
        {
            //验证
            if (model.Captcha != Session[Keys.CAPTCHA].ToString())
            {
                ModelState.AddModelError(model.Captcha, "验证码填错啦");
                return View(model);
            }

            ForgetModel forgetModel = new ForgetModel();
            if (model.Email != null)
            {
                forgetModel = passwordService.FindUserInfo(model);
                if (model.Email == forgetModel.Email)
                {
                    EmailCheckOut(model, passwordService);
                }
                //else nothing
            }
            else if (model.UserName != null)
            {
                forgetModel = passwordService.FindUserInfo(model);
                if (model.UserName == forgetModel.UserName)
                {
                    EmailCheckOut(model, passwordService);
                }
                //else nothing
            }
            else
            {
                ModelState.AddModelError(model.Email, "请您填写内容");
                return View();
            }


            return View();
        }

        private void EmailCheckOut(ForgetModel model, PasswordService passwordService)
        {
            EmailController email = new EmailController();
            int captcha = email.EmailActivate(new ActivateModel
            {
                Email = model.Email,
                Expire = DateTime.Now.AddMinutes(10),
                UserName=model.UserName

            },"改变密码");
        }
        #endregion


        #region ChangePassword
        [ModelErrorTransferFilter]
        public ActionResult Change()
        {
            return View();
        }
        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult Change(ChangeModel model)
        {
            if (passwordService.GetUserPassword() != model.FormerPassword.MD5Crypt())
            {
                ModelState.AddModelError(model.FormerPassword, "原来的密码不对，请好好想一想哦");
                return View(model);
            }
            model.NewPassword = model.NewPassword.MD5Crypt();
            passwordService.AddNewPwd(model);
            return View();
        }
        #endregion

        #region ResetPassword
        public ActionResult Reset(string captcha)
        {
            string chptcha = HttpContext.Request.QueryString[Keys.email].ToString();
            ResetModel resetModel = new ResetModel();
            resetModel = passwordService.GetUserCaptcha(chptcha);
            if (resetModel==null)
            {
                ModelState.AddModelError(resetModel.Captcha, "验证时间过期");
                return View();
            }
            if (captcha!=resetModel.Captcha)
            {
                ModelState.AddModelError(resetModel.Captcha, "验证密码不对，请填写正确的验证码");
                return View();
            }
            return View();
        }
        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult Reset(ResetModel model) {
            passwordService.ResetPassword(model.Captcha, model.NewPassword);
            return View("Home/Index");
        }
        #endregion

    }
}