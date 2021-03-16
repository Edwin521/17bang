using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Filter
{
    public class NeedLogOnAttribute : ActionFilterAttribute
    {
        private string role;
        public NeedLogOnAttribute(string role)
        {
           this.role = role;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContextBase httpContextBase = filterContext.HttpContext;
            HttpRequestBase httpRequestBase = httpContextBase.Request;

            string perPage = httpRequestBase.Path + httpRequestBase.QueryString;

            string LogOnUser = httpContextBase.Request.Cookies.Get(Keys.CookieName).ToString();
            if (string.IsNullOrEmpty(LogOnUser))
            {
                filterContext.Result = new RedirectResult($"Log/On?{Keys.Prepage}={perPage}&{Keys.Role}={role}");
            }//else nothing
            base.OnActionExecuting(filterContext);
        }
    }
}