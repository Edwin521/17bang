using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18bangMVC.Models
{
    public class RegisterModel
    {
        public string InviterName { get; set; }
        public string InviterCode { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Captcha { get; set; }
    }
}