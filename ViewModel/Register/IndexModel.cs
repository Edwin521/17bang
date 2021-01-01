using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _18bangMVC.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="*邀请人不能为空")]
        public string InviterName { get; set; }

        [Required(ErrorMessage ="*邀请码不能为空")]
        public string InviterCode { get; set; }

        [Required(ErrorMessage ="用户名（*必填）")]
        public string Name { get; set; }

        [Required(ErrorMessage ="密码（*必填）")]
        public string Password { get; set; }

        [Required(ErrorMessage ="验证密码（*必填）")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="验证码（*必填）")]
        public string Captcha { get; set; }
    }
}