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
        public Article Find(int userId)
        {
          return  dbSet.Where(a => a.Author.Id == userId).FirstOrDefault();
        }

        public int Save(Article article)
        {
            return dbSet.Add(article).Id;
        }
      
    }
}
