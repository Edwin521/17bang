﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class PlanController : BaseController
    {
        // GET: Plan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            return View();
        }
    }
}