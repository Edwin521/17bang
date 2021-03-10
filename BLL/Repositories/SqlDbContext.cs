using BLL.Entities;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SqlDbContext<T> : SqlDbContext where T : BaseEntity
    {

    }


    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("17bang")
        {
            Database.Log = s => Debug.Write(s);
        }
        //public DbSet<Article> Articles { get; set; }
        //public DbSet<Problem> Problems { get; set; }
        //public DbSet<Keyword> Keywords { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Comment> Comments { get; set; }
       


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Article>();
            modelBuilder.Entity<Comment>();
            modelBuilder.Entity<Keyword>();
            modelBuilder.Entity<Problem>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
