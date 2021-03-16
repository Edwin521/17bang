using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Repositories;
namespace ProdServices
{
    public class EmailService : BaseService
    {
        private User user;
        public EmailService()
        {
            user = new User();
        }
        public bool ActivateEmail(int UserId, string captcha)
        {
            user = userRepository.Find(UserId);
            if (user.Email.Expire==null)
            {
                return false;
            }
            return captcha == user.Email.Captcha;
        }

        public void HasVaild(int id)
        {
            user = userRepository.Find(id);
            user.Email.IsActive = true;
            userRepository.Update(user);
        }
    }
}
