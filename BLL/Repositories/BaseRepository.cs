using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<T> where T : BaseEntity,new()
    {
        protected SqlDbContext context;
        protected DbSet<T> dbSet;
        public BaseRepository(SqlDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }



        public T Find(int? id)
        {
            return dbSet.Find(id);
        }
        public int Save(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public T Load(int id) {
            T entity = new T { Id = id };
            dbSet.Attach(entity);
            return entity;
        }



    }
}
