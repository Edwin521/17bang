using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel.Password
{
    public class ForgetModel
    {
        [Required(ErrorMessage ="Email不能为空")]
        [EmailAddress(ErrorMessage ="电子邮件格式不正确")]
        public string Email { get; set; }

        public string UserName { get; set; }
        [Required(ErrorMessage ="验证码不能为空")]
        public string Captcha { get; set; }
        public string QQ { get; set; }
    }
}
