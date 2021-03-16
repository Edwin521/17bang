using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18bangMVC.Helper
{
    public class CookieHelper
    {

        public static void addCookie(int userId, string password, bool remberMe = false)
        {
            HttpCookie cookie = new HttpCookie(Keys.CookieName);
            cookie.Values[Keys.Id] = userId.ToString();
            cookie.Values[Keys.Password] = password;
            if (remberMe)
            {
                cookie.Expires = DateTime.Now.AddDays(14);
            }
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}