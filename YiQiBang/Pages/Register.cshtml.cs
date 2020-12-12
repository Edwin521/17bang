using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YiQiBang.Repositories;

namespace YiQiBang.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private UserRepepository userRepository;
        public RegisterModel()
        {
            userRepository = new UserRepepository();
        }
        public Entities.User NewUser { set; get; }

        [Required(ErrorMessage = "*确认密码不能为空")]
        [Compare(nameof(Password), ErrorMessage = "*两次密码输入的不一致，请重新输入")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "*验证码不能为空")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "*验证码的长度只能等于4")]
        public string Captcha { get; set; }

        public void OnGet()
        {


        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            Entities.User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);
            //if (invitedBy==null)
            //{

            //}
            //if (invitedBy.InviteCode!=NewUser.InvitedBy.InviteCode)
            //{

            //}
            NewUser.InvitedBy = invitedBy;
            NewUser.Register();
            userRepository.Save(NewUser);
        }
    }
}