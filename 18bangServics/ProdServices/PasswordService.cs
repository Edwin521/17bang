using _18bangServices.ViewModel.Password;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdServices
{
    public class PasswordService : BaseService
    {
        private User user;
     
        public PasswordService()
        {
            user = new User();
        }
        //取到当前用户原来的密码
        public string GetUserPassword()
        {
            return userRepository.Find(CurrentUserId).Password;
        }
        //新老密码更替
        public void AddNewPwd(ChangeModel model)
        {
            try
            {
                user = userRepository.Find(CurrentUserId);
                user.Password = model.NewPassword;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public ForgetModel FindUserInfo(ForgetModel model)
        {
            if (model.Email!=null)
            {
                user = userRepository.FindByEmail(model.Email);
            }
            else if (model.UserName!=null)
            {
                user = userRepository.GetByName(model.UserName);
            }
            else
            {
                return null;
            }
            ForgetModel forgetModel = mapper.Map<ForgetModel>(user);
            forgetModel.Email = user.Email.Address;
            return forgetModel;
        }

        public ResetModel GetUserCaptcha(string captcha)
        {
            user = userRepository.FindUserCaptcha(captcha);
            ResetModel resetModel = new ResetModel();
            if (user.Email.Expire==null)
            {
                return null;
            }
            resetModel.Captcha = user.Email.Captcha;
            return resetModel;
        }

        public void ResetPassword(string captcha, string newPassword)
        {
            user = userRepository.FindUserCaptcha(captcha);
            user.Password = newPassword;
        }
    }
}
