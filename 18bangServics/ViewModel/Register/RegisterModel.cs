using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _18bangServices.ViewModel
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="*邀请人不能为空")]
        public string InviterName { get; set; }
        [StringLength(4,MinimumLength =4,ErrorMessage ="邀请码只能是4位数字") ]
        [Required(ErrorMessage ="*邀请码不能为空")]
        public string InviterCode { get; set; }

        [Required(ErrorMessage ="用户名（*必填）")]
        public string Name { get; set; }

        [Required(ErrorMessage ="密码（*必填）")]
        public string Password { get; set; }

        [Required(ErrorMessage ="验证密码（*必填）")]
        [Compare("Password",ErrorMessage ="确认密码和密码不一致")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "验证码（*必填）")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "验证码的长度只能是4位")]
        public string Captcha { get; set; }

        public int CookieId { get; set; }
    }
}