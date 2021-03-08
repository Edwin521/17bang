using _18bangMVC.Filter;
using _18bangMVC.Models;
using _18bangServices.ViewModel.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        [ModelErrorTransferFilter]

        public ActionResult On()
        {

            //if (TempData["errrorMessage"] != null)
            //{
            //    ModelState.Merge((TempData["errrorMessage"] as ModelStateDictionary));
            //} 

            //OnModel model = new OnModel
            //{
            //    Name = "LZB",
            //    Password = "1234",
            //    Captcha = "3452"
            //};


            //Session["user"] = new RegisterModel
            //{
            //    Name = "lzb",
            //};
            return View();



        }
        [HttpPost]
        [ModelErrorTransferFilter]

        public ActionResult On(OnModel model )
        {
            //if (!ModelState.IsValid)
            //{
            //    TempData["errrorMessage"] = ModelState;
            //    return RedirectToAction(nameof(On));
            //}
            return RedirectToAction(nameof(On));
        }




        public ActionResult Off() {
            return View();

        }
        [HttpPost]
        public ActionResult Off(OffModel model)
        {
            return View();

        }

    }
}