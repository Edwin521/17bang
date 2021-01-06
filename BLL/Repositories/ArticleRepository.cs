using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository(DbContext context) : base(context)
        {
        }
        public int AddArticleToDb(Article article)
        {
            entities.Add(article);
            context.SaveChanges();
            return article.Id;
        }

        public Article Find(int articleId)
        {
            return entities.Where(a => a.Id == articleId).FirstOrDefault();
        }
        public IList<Article> GetArticles(int pageSize, int pageIndex)
        {
            return entities.Include(e => e.Author)
                .OrderByDescending(a => a.PublishTime)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public IList<Article> GetSeriesArticle(int id, bool Asc, int takeArticleNum)
        {
            IList<Article> temp = new List<Article>();
            temp = GetSeriesArticle(id, Asc);
            if (takeArticleNum == 1000)
            {
                return temp.Take(1000).ToList();
            }
            if (takeArticleNum == 50)
            {
                return temp.Take(50).ToList();
            }
            return temp.Take(10).ToList();
        }

        public IList<Article> GetSeriesArticle(int id, bool asc)
        {
            return null;
        }
    }
}
