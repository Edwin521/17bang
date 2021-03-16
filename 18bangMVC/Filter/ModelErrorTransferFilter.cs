using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Filter
{
    public class ModelErrorTransferFilter : ActionFilterAttribute
    {
        //实现 在action或者controller声明一个特性就可以实现Model验证的PRG模式。
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ModelStateDictionary modelState = ((Controller)filterContext.Controller).ModelState;
            if (filterContext.HttpContext.Request.HttpMethod == Keys.POST)
            {
                if (!modelState.IsValid)
                {
                    filterContext.Controller.TempData[Keys.ErrorInModel] = modelState;
                    filterContext.Result = new RedirectResult(filterContext.HttpContext.Request.Url.PathAndQuery);

                }

            }
            else if (filterContext.HttpContext.Request.HttpMethod == Keys.GET)
            {
                ModelStateDictionary errors = filterContext.Controller.TempData[Keys.ErrorInModel] as ModelStateDictionary;

                if (errors!=null)
                {
                    modelState.Merge(errors);
                }//else nothing 
            }
            else
            {
                throw new NotImplementedException();
            }
            base.OnActionExecuting(filterContext);

        }
        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    base.OnActionExecuted(filterContext);
        //}
        //public override void OnResultExecuting(ResultExecutingContext filterContext)
        //{
        //    base.OnResultExecuting(filterContext);
        //}
        //public override void OnResultExecuted(ResultExecutedContext filterContext)
        //{
        //    base.OnResultExecuted(filterContext);
        //}



    }
}