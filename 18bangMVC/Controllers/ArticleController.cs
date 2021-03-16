
using _18bangMVC.Filter;
using _18bangServices.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProdServices;
using _18bangServices.ViewModel;

namespace _18bangMVC.Controllers
{
    public class ArticleController : BaseController
    {


        private ArticleService articleService;
        private UserService registerService;
        public ArticleController()
        {
            articleService = new ArticleService();
            registerService = new UserService();
        }
        public ActionResult Index( int id=1) {
            ArticleIndexModel model = new ArticleIndexModel { Items = new List<ArticleItemModel>()};
            model = articleService.GetArticles(2, id);
            model.SumOfArticle = articleService.GetCount();
            return View(model);
        }
     
        #region New页面
        [ModelErrorTransferFilter]
        public ActionResult New()
        {

            return View();
        }


        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult New(NewModel model)
        {

            int articleId = articleService.Publish(model);
            return RedirectToAction(Keys.Single, new { id = articleId });
        }
        #endregion


        #region Single页面
        public ActionResult Single(int id)
        {
            SingleModel model = articleService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Single()
        {
            return View();
        }
        #endregion




        #region Edit 修改文章内容页面
        public ActionResult Edit(int? id)
        {
            EditModel model = articleService.GetEdit(id.Value);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
        #endregion


    }
}