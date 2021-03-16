using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel.Email
{
    public class ActivateModel
    {
        public string UserName { get; set; }

        [Required(ErrorMessage ="Email地址不能为空")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "验证码不能为空")]
        public string Captcha { get; set; }

        public DateTime? Expire { get; set; }
        public bool IsActivate { get; set; }
    }
}
