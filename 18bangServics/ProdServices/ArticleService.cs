using _18bangServices.ViewModel;
using _18bangServices.ViewModel.Article;
using AutoMapper;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdServices
{
    public  class ArticleService:BaseService
    {
        private ArticleRepository articleRepository;
        private UserRepository userRepository;
        private Article article;
        public ArticleService()
        {
           
            articleRepository = new ArticleRepository(Context);
            userRepository = new UserRepository(Context);
            article = new Article();
        }
        public int Publish(NewModel model)
        {
             article = mapper.Map<Article>(model);
            article.PublishArticle();
            article.Author = CurrenUser;

            return articleRepository.Save(article);
        }

        public ArticleIndexModel GetArticles(int pageSize, int pageIndex)
        {
            IList<Article> tempArticle = new List<Article>();
            tempArticle = articleRepository.GetArticles(pageSize, pageIndex);
            ArticleIndexModel ArticleIndexModel = new ArticleIndexModel
            {
                Items = mapper.Map<List<ArticleItemModel>>(tempArticle)

            };
            return ArticleIndexModel;
        }

        public int GetCount()
        {
            return articleRepository.ArticleCount();
        }

        public SingleModel GetById(int id) {
            Article article = articleRepository.Find(id);
            SingleModel model = mapper.Map<SingleModel>(article);
            return model;
        }

        public EditModel GetEdit(int id)
        {
            article = articleRepository.Find(id);
            return mapper.Map<EditModel>(article);
        }
    }
}
