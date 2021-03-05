using _18bangServices.ViewModel.Article;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ProdServices
{
    public class ArticleService : BaseService
    {

        private ArticleRepository repository;
        private Article article;
        public ArticleService()
        {
            repository = new ArticleRepository(dbContext);
            article = new Article();
        }

        public SingleModel GetSingleArticle(int id)
        {
            article = repository.Find(id);
            SingleModel temp = Mapper.Map<SingleModel>(article);

            return temp;
        }
        public int GetCount()
        {
            return repository.GetArticleCount();
        }
    }
}
