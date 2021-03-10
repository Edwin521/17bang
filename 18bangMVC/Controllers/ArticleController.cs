
using _18bangMVC.Filter;
using _18bangServices.ViewModel.Article;
using BLL.Entities;
using BLL.Repositories;
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



        private ArticleRepository articleRepository;
        private UserRepository userRepository;
        public ArticleController()
        {
            articleRepository = new ArticleRepository();
            userRepository = new UserRepository();
        }

        [ModelErrorTransferFilter]
        public ActionResult New( )
        {

            return View();
        }


        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult New(NewModel model )
        {
            int currentUserId = 1;
            Article article = new Article
            {
                Title = model.Title,
                Body = model.Body,
            };
            User author = userRepository.find(currentUserId);
    
            article.Author = author;
            articleRepository.Save(article);
            return View();
        }

    }
}