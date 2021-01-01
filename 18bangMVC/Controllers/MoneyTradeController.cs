using _18bangMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class MoneyTradeController : Controller
    {
        // GET: MoneyTrade
        public ActionResult Sale()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sale(SaleModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(model.ByFrom, "帮帮币出售很关键，请详细填写！");
                return View(model);
            }
            return Redirect("/Home/Index");
        }

    }
}