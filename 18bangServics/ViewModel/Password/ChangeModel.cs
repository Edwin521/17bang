using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel.Password
{
    public class ChangeModel
    {
        [Required(ErrorMessage ="原密码不能为空")]
        [StringLength(20,MinimumLength =4,ErrorMessage ="原密码长度不能小于4，大于25")]
        public string FormerPassword  { get; set; }
        [Required(ErrorMessage = "新密码不能为空")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "新密码长度不能小于4，大于25")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "确认密码不能为空")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "确认密码长度不能小于4，大于25")]
        public string ConfirmPassword { get; set; }
    }
}
