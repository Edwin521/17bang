using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
    //自己创建一个类继承自Dbcontext
    class SqlDbContext :DbContext
    {
       
        //这里不可以使用字段
        public DbSet<User> Users { get; set; }
        public DbSet<Problem> problems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=19bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //usesqlserver()需要添加一个引用
            optionsBuilder.UseSqlServer(connStr)
                         
        #if DEBUG
                            .EnableSensitiveDataLogging(true);
         #endif

            base.OnConfiguring(optionsBuilder); 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>(u =>
            //{
            //    u.ToTable("Register");
            //    u.Property(u => u.Name).HasColumnName("UserName");
            //    u.Property(u => u.Name).HasMaxLength(256);
            //    u.Property(u => u.Password).IsRequired();
            //    u.HasKey(u => u.Name);
            //    u.HasIndex(u => u.Name);
            //    u.HasIndex(u => u.CreateTime).IsClustered(false);
            //    u.Ignore(u => u.FailedTry);
               
            //});
        }

    }
}
