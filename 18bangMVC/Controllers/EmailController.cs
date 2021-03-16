using _18bangMVC.Filter;
using _18bangServices.ViewModel.Email;
using ProdServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class EmailController : BaseController
    {

        private EmailService emailService;
        public EmailController()
        {
            emailService = new EmailService();
        }
        
        public ActionResult Activate(int id,string email,string captcha)
        {
            bool success = emailService.ActivateEmail(id, captcha);
            if (!success)
            {
                ModelState.AddModelError(captcha, "邮箱或者验证密码不正确");
                return View();
            }
            emailService.HasVaild(id);
            return View();
        }


        public int EmailActivate(ActivateModel model,string subject="激活验证码",string body=null) {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("feige_20200214@163.com");
            mail.To.Add(model.Email);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            int captcha = new Random().Next(1111, 9999);

            if (body==null)
            {
                body = $@"亲爱的一起帮用户——{model.UserName},您好,你的验证码是{captcha},您也可以点击下面的链接重置密码，
                http://localhost:59397/Password/Reset/Captcha={captcha}?Email={model.Email}";
            }
            mail.Body = body;
            SmtpClient client = new SmtpClient("smtp.163.com");
            client.Port = 25;
            client.Credentials = new System.Net.NetworkCredential("feige_20200214@163.com", "yz17bang");
            client.EnableSsl = false;


            client.Send(mail);

            return captcha;
        }
    }
}