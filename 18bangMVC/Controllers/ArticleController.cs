
using _18bangServices.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        //private ArticleService service;
        //public ArticleController()
        //{
        //    service = new ArticleService();
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult Single(int id)
        //{
        //    return View(service.GetSingleArticle(id));
        //}
        //public ActionResult New()
        //{
         
        //    return View();
        //}

        [HttpPost]
        public ActionResult New(NewModel model )
        {
            int currentUserId = 1;
          

            return View();
        }

    }
}