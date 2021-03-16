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
        public ArticleRepository(SqlDbContext context) : base(context)
        {
        }

        public Article Find(int articleId)
        {
            return dbSet.Where(a => a.Id == articleId).FirstOrDefault();
        }

        public int Save(Article article)
        {
             dbSet.Add(article);
            context.SaveChanges();
            return article.Id;
        }

        public IList<Article> GetArticles(int pageSize, int pageIndex)
        {
            return dbSet.Include(d => d.Author).
                  Include(a => a.Keywords).
                  OrderByDescending(a => a.PublishTime).
                  Skip((pageIndex - 1) * pageSize).
                  Take(pageSize).
                  ToList();
        }

        public int ArticleCount()
        {
            return dbSet.Count();
        }

    }
}
