using ProdServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Filter
{
    public class ContextPerRequest : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ///保证非数据库的异常也会回滚，比如前面跑的页面抛出了一个异常，同样也会回滚。    
            if (filterContext.Exception==null)
            {
                BaseService.Commit();

            }
            else
            {
                BaseService.RollBack();
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }
}