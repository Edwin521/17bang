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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=19bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //usesqlserver()需要添加一个引用
            optionsBuilder.UseSqlServer(connStr);
            base.OnConfiguring(optionsBuilder); 
        }

    }
}
