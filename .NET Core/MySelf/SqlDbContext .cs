﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
    //自己创建一个类继承自Dbcontext
    class SqlDbContext : DbContext
    {

        //这里不可以使用字段
        public DbSet<User> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<BMoney> BMoneys { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=19bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //usesqlserver()需要添加一个引用
            optionsBuilder.UseSqlServer(connStr)
               .EnableSensitiveDataLogging()
               .LogTo(
               (id, level) => level == LogLevel.Error,
               log => Console.WriteLine(log)   //如何记录log
                );



            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(u =>
            {
                //u.ToTable("Register");
                //u.Property(u => u.Name).HasColumnName("UserName");
                //u.Property(u => u.Name).HasMaxLength(256);
                //u.Property(u => u.Password).IsRequired();
                //u.HasKey(u => u.Name);
                //u.HasIndex(u => u.Name);
                //u.HasIndex(u => u.CreateTime).IsClustered(false);

                u.HasOne<Email>(u => u.SendTo).WithOne(u => u.FromWho).HasForeignKey<User>(u => u.SendToId);

            });
        }

    }
}
