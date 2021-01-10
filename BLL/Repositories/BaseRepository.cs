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
        protected DbContext context;
        public BaseRepository(DbContext context)
        {
            this.context = context;
        }
        protected DbSet<T> entities
        {
            get => context.Set<T>();
        }
        public T Find(int? id)
        {
            return entities.Find(id.Value);
        }
        public int Save(T entity)
        {
            entities.Add(entity);
            context.SaveChanges(); 
            return entity.Id;
        }
    }
}
