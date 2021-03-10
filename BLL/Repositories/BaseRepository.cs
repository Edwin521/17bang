using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected SqlDbContext context;
        protected DbSet<T> dbSet;
        public BaseRepository()
        {
            context = new SqlDbContext();
            dbSet = context.Set<T>();
        }



        public T find(int? id)
        {
            return dbSet.Find(id.Value);
        }
        public int save(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
    }
}
