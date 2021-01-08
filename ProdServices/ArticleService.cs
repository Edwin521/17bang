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
    }
}
