using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel.Password
{
    public class ResetModel
    {
        [Required(ErrorMessage ="新密码不能为空")]
        [StringLength(30,MinimumLength =4,ErrorMessage ="新密码的长度不能小于4，大于30")]
        public string NewPassword { get; set; }


        [Required(ErrorMessage = "确认密码不能为空")]
        [Compare("NewPassword",ErrorMessage ="确认密码和密码不一致")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="验证码不能为空")]
        [StringLength (4,MinimumLength =4,ErrorMessage ="验证码只能为4位")]
        public string Captcha { get; set; }
    }
}
