using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
  public  class SqlDbContext:DbContext
    {
        public SqlDbContext():base("18bang")
        {

        }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Article>();
            modelBuilder.Entity<Problem>();
            modelBuilder.Entity<BMoney>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
