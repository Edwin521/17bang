﻿using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MySelf
{
    public class Program
    {




        static void Main(string[] args)
        {
            //string connectionString =
            //@"Data Source=(localdb)\MSSQLLocalDB;
            //        Initial Catalog=18bang;Integrated Security=True;";
            ////IDbConnection connection = new SqlConnection(connectionString);//生成一个connection对象
            //using (IDbConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    //command.CommandText = @"Insert [User]([Name],[Password],InviteById,InvitedCode)
            //    //Values(@UserName,@Password,@InviteName, @InvitedCode,
            //    //(Select Id From[User] Where UserName = @InviteName)) ";
            //    command.CommandText = "SELECT * FROM [USER]";

            //    IDataReader reader=command.ExecuteReader();


            //    while (reader.Read())
            //    {
            //        for (int i = 0; i < reader.FieldCount; i++)
            //        {
            //            Console.Write(reader[i]+"    ");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //将User类映射到数据库：
            //SqlDbContext context = new SqlDbContext();
            //User user = new User
            //{
            //    Id=1,
            //    Name = "周丁浩",
            //    IsFamle = "true",
            //};
            //context.Users.Add(user);
            //context.SaveChanges();


            //使用EF的API直接建库建表删库
            #region 
            //var db = context.Database;
            //db.EnsureDeleted();
            //db.EnsureCreated();
            #endregion

            //使用Migration工具建库建表
            //Add-Migration AddDatabaseAndUser
            //Update-Database

            //Migration之后，在User类上添加一列：int FailedTry（尝试登陆失败次数），使用Migration工具：
            //Add-Migration Add_User_FailedTry

            //将改动同步到数据库
            //Update-Database

            //回退数据库到FailedTry添加之前
            //Update-Database 20201215075910_AddDatabaseAndUser


            ///EF配置：表名 / 列名 / 数据类型 / 可空 / 主键 / 索引…作业
            //分别使用OnModelCreating()和Data Annotations，完成以下配置：
            //将之前的User类名改为Register，但仍然能对应表User
            //EF会默认使用DbSet属性名
            //{有两种方式修改表名和列名：1,modelBuilder.Entity<NewStudent>().ToTable("新的表名或者列名"); 
            //                         2,直接在类的声明上面加特性 [Table("新的表名或列名")]     }


            //将之前的User属性Name改成UserName，但仍然能对应表User的列Name
            //和上面修改表明一样，同样通过那两种方式都可以修改。

            //将Name的长度限制为256
            //字符串属性限制长度，通过在属性名上加特性[MaxLength(长度)]实现
            //或者在modelBuilder里面进行设置配置

            //Password不能为空
            //EF中值类型属性默认映射是not null的，对于引用类型想使其变为not null，一种是在modelBuilder里面进行配置，另一种就是在属性加特性[required]。

            //将User表的主键设置在Name列上
            //EF默认id为主键，要使其他属性设为主键的话，1,要在modelBuilder.-hasKey()里进行配置
            //                                      2,或者直接在属性上加特性[key]。
            //联合主键的设置要在onmodelcreating()中

            //User类中的属性FailedTry不用存储到数据库中
            //给CreateTime属性添加一个非聚集唯一索引
            //默认为非聚集索引，EF core 目前还没办法指定聚集索引，声明索引唯一非唯一在类上声明指定，或者modelBuilder里声明配置。

            //CreateTime不能小于2000年1月1日



            //作业： 单个Entity：基本增删改查和ChangeTracker
            //利用EF，插入3个User对象
            //SqlDbContext context = new SqlDbContext();
            //context.AddRange(
            //    new User { Name = "zdh", Password = "1234" },
            //    new User { Name = "lw", Password = "5210" },
            //    new User { Name = "zl", Password = "5555" });
            //context.SaveChanges();


            //通过Id找到其中一个User对象
            //User findUser = context.Find<User>(1);
            //Console.WriteLine(findUser.Name);
            //context.SaveChanges();


            //修改该User对象的Name属性，将其同步到数据库
            //User findUser = context.Find<User>(1);
            //findUser.Name = "LZBNB";
            //context.SaveChanges();
            //Console.WriteLine(findUser.Name);


            //不加载User对象，仅凭其Id用一句Update SQL语句完成上题
            //User user = new User { Id = 1 };
            //context.Attach<User>(user);
            //user.Name = "LZBZNB";
            //context.SaveChanges();


            //删除该Id用户
            //User u1 = context.Find<User>(1);
            //context.Remove<User>(u1);
            //context.SaveChanges();


            // ////EF：Logger和条件编译符作业

            //能够在EF core上配置成功Logger到Debug窗口
            //#if DEBUG
            //.EnableSensitiveDataLogging(true)
            //#endif


            //能够在EF6上配置成功Logger到控制台
            //EF6没写


            //Linq to IQueryable和Expression作业

            //利用Linq to EntityFramework，实现方法：
            //GetBy(IList < ProblemStatus > exclude, bool hasReward, bool descByPublishTime)，该方法可以根据输入参数：
            //IList<ProblemStatus> exclude：不显示（排除）某些状态的求助
            //bool hasReward：只显示已有酬谢的求助（如果传入值为true的话）
            //bool descByPublishTime：按发布时间正序还是倒序

            new ProblemRepository().GetBy(new List<ProblemStatus> { new ProblemStatus { } }, false, false);

            //EF：关联对象：映射和加载作业
            //观察一起帮的功能，思考并
            //Email和User有一对一的关系，参照课堂演示，在数据库上建立User外键引用Email的映射


            //User lzb = new User { Name = "lzb", Password = "1234" };
            //Email email = new Email { EmailLocation = "123456@qq.com" };
            //lzb.SendTo = email;
            //email.FromWho = lzb;

            //context.Add<User>(lzb);
            //context.Add<Email>(email);
            //context.SaveChanges();
            //按继承映射：Blog / Article / Suggest以及他们的父类Content
            //所以要使类的关系的构建Blog / Article / Suggest 这三个类都继承自content


            // EF core：事务和UoW作业
            //用事务实现帮帮币出售的过程
            //卖方帮帮币足够，扣减数额后成功提交。
            // 卖房帮帮币不够，事务回滚，买卖双方帮帮币不变。


            //int tranBMoney = 30;
            ////买家和卖家的信息
            //User saleUser = context.Users.Where(u => u.Name == "zdh").SingleOrDefault();
            //BMoney saleUserMoney = context.BMoneys.OrderByDescending(m => m.LatesTime).Where(m => m.Owner == saleUser).FirstOrDefault();

            //User buyUser = context.Users.Where(u => u.Name == "lzb").SingleOrDefault();
            //BMoney buyUserInfo = context.BMoneys.OrderByDescending(m => m.LatesTime).Where(m => m.Owner == buyUser).FirstOrDefault();

            ////有足够的钱支付
            //if ((saleUserMoney.LeftBMoney - tranBMoney) < 0)
            //{
            //    return;
            //};

            //BMoney ofSaleUser = new BMoney
            //{
            //    Owner = saleUser,
            //    LeftBMoney = saleUserMoney.LeftBMoney - tranBMoney,
            //    LeftBPoint = saleUserMoney.LeftBPoint,
            //    Detail = $"您成功在{DateTime.Now}出售了{tranBMoney}帮帮币 ",
            //    FreezingMoney = 0,
            //    LatesTime = DateTime.Now
            //};
            //BMoney ofBuyUser = new BMoney
            //{
            //    Owner = buyUser,
            //    LeftBMoney = buyUserInfo.LeftBMoney + tranBMoney,
            //    LeftBPoint = saleUserMoney.LeftBPoint,
            //    Detail = $"您成功的在 {DateTime.Now} 从{saleUser.Name}那里购买了 {tranBMoney} 帮帮币 ",
            //    FreezingMoney = 0,
            //    LatesTime = DateTime.Now
            //};
            //context.BMoneys.AddRange(new BMoney[] { ofSaleUser, ofBuyUser });
            //context.SaveChanges();


            //关联对象：存储 作业
            //  完成以下entity的创建和ORM映射：
            //    关键字
            //    文章分类
            //    帮帮点 / 帮帮币


            //以及相应的增删改查功能：

            //    发布文章和求助时包含关键字（keyword）
            //多对多关系

            //    可以按关键字筛选求助

            //先插数据
            //SqlDbContext context = new SqlDbContext();
            //Keyword keywords1 = new Keyword { Word = "Keywords1" };
            //Keyword keywords2 = new Keyword { Word = "Keywords2" };
            //Keyword keywords3 = new Keyword { Word = "Keywords3" };
            //Keyword keywords4 = new Keyword { Word = "Keywords4" };

            ////----------------------------------------------------------------------------------------------

            //Article article1 = new Article { Title = "Insert Article Title 1", Body = "Insert Article Body 1", Summary = "None" };
            //Article article2 = new Article { Title = "Insert Article Title 2", Body = "Insert Article Body 2", Summary = "None" };

            //article1.keywords = new List<Keyword> { keywords1, keywords2 };

            //article2.keywords = new List<Keyword> { keywords3, keywords2, keywords4 };

            //context.AddRange(article1, article2);
            ////----------------------------------------------------------------------------------------------

            //Problem problem1 = new Problem { Title = "Insert problem Title -1", Body = "Insert problem Body -1", Reward = 5 };
            //Problem problem2 = new Problem { Title = "Insert problem Title -2", Body = "Insert problem Body -2", Reward = 5 };
            //Problem problem3 = new Problem { Title = "Insert problem Title -3", Body = "Insert problem Body -3", Reward = 5 };

            //problem1.keywords = new List<Keyword> { keywords1, keywords2 };

            //problem2.keywords = new List<Keyword> { keywords2, keywords3 };

            //problem3.keywords = new List<Keyword> { keywords3, keywords4, keywords1 };

            //context.AddRange(problem1, problem2, problem3);

            ////----------------------------------------------------------------------------------------------

            //context.SaveChanges();

            //SqlDbContext context = new SqlDbContext();
            //Keyword haveProblem = context.Keywords.Where(k => k.Word == "Keywords1").Include(k => k.problems).Single();
            //haveProblem.problems = haveProblem.problems ?? new List<Problem>();
            //haveProblem.problems.Where(p => p.keywords == haveProblem);
            //foreach (var item in haveProblem.problems)
            //{
            //    Console.WriteLine(item.Title);
            //}

            //haveProblem.problems.Where(p =>p.keywords.Contains "");

            //foreach (var item in haveProblem.Of_ThisProblem)
            //{
            //    Console.WriteLine(item.Problem.Title);
            //}

            //    能够按作者（Author）/ 分类（Category）显示文章列表
            //SqlDbContext context = new SqlDbContext();
            //Kind kind1 = new Kind { Name = "Status-1" };
            //Kind kind2 = new Kind { Name = "Status-2" };
            //Kind kind3 = new Kind { Name = "Status-3" };
            //context.Kinds.AddRange(kind1, kind2, kind3);

            //User lzb = context.Users.Where(u => u.Name == "lzb").FirstOrDefault();
            //User zdh = context.Users.Where(u => u.Name == "zdh").FirstOrDefault();


            //Kind kind1 = context.Kinds.Where(k => k.Name == "Status-1").FirstOrDefault();
            //Kind kind2 = context.Kinds.Where(k => k.Name == "Status-2").FirstOrDefault();
            //Kind kind3 = context.Kinds.Where(k => k.Name == "Status-3").FirstOrDefault();
            //Problem problem = new Problem
            //{
            //    Title = "Problem Title",
            //    Body = "nothing",
            //    Summary = "nothing",
            //    PublishTime = DateTime.Now.AddDays(-12),
            //    Author = lzb,
            //    HaveKind = kind1,
            //    Reward = 10,
            //    Status = ProblemStatus.inprocess
            //};
            //Problem problem1 = new Problem
            //{
            //    Title = "Problem Title-1",
            //    Body = "nothing",
            //    Summary = "nothing",
            //    PublishTime = DateTime.Now.AddDays(-13),
            //    Author = lzb,
            //    HaveKind = kind2,
            //    Reward = 10,
            //    Status = ProblemStatus.inprocess
            //};
            //Problem problem2 = new Problem
            //{
            //    Title = "Problem Title-2",
            //    Body = "nothing",
            //    Summary = "nothing",
            //    PublishTime = DateTime.Now.AddDays(-143),
            //    Author = zdh,
            //    HaveKind = kind2,
            //    Reward = 10,
            //    Status = ProblemStatus.Rewarded
            //};
            //Problem problem3 = new Problem
            //{
            //    Title = "Problem Title-3",
            //    Body = "nothing",
            //    Summary = "nothing",
            //    PublishTime = DateTime.Now.AddDays(-143),
            //    Author = zdh,
            //    HaveKind = kind3,
            //    Reward = 10,
            //    Status = ProblemStatus.Rewarded
            //};

            //context.Problems.AddRange(problem, problem1, problem2, problem3);

            //context.SaveChanges();


            //----------------------------------------

            //SqlDbContext context = new SqlDbContext();
            //User userHaveThisProblem = context.Users.Where(u=>u.Name=="lzb").Include(u => u.Problems).SingleOrDefault();

            //userHaveThisProblem.Problems = userHaveThisProblem.Problems ?? new List<Problem>();
            //userHaveThisProblem.Problems.Where(p => p.Author.Name ==userHaveThisProblem.Name);
            //foreach (var item in userHaveThisProblem.Problems)
            //{
            //    Console.WriteLine(item.Title);
            //}

            //---------------------------------------------
            //SqlDbContext context = new SqlDbContext();
            //Kind haveThisKindProblem = context.Kinds.Include(k => k.ThisProblem).FirstOrDefault(k => k.Name == "待协助");

            //haveThisKindProblem.ThisProblem = haveThisKindProblem.ThisProblem ?? new List<Problem>();
            //haveThisKindProblem.ThisProblem.Where(k => k.HaveKind == haveThisKindProblem);
            //foreach (var item in haveThisKindProblem.ThisProblem)
            //{
            //    Console.WriteLine(item.Title);
            //}

            //     能够选择文章列表的排序方向（按发布时间顺序倒序）和每页显示格式（50篇标题 / 10篇标题 + 摘要）
            //IList<Problem> tempList = new List<Problem>();
            //tempList = new Program().GetProblemOrderBy(true).GetContextTitleBy(true, 50).ToList();
            //foreach (var item in tempList)
            //{
            //    Console.WriteLine(item.Title, item.Summary);
            //}


            //    发布文章会：扣掉作者1枚帮帮币、增加10个帮帮点
            //    发布求助时可以设置悬赏帮帮币，发布后会被冻结，求助被解决时会划拨给好心人
            //    帮帮点和帮帮币的每一次变更都会被记录并可以显示

        }
        //public IQueryable<Problem> GetProblemOrderBy(bool publishTimeDesc)
        //{
        //    SqlDbContext context = new SqlDbContext();
        //    if (publishTimeDesc)
        //    {
        //        return context.Problems.OrderByDescending(p => p.PublishTime);
        //    }
        //    return context.Problems.OrderBy(p => p.PublishTime);
        //}
    }
    //public static class Extensions
    //{
    //    public static IQueryable<Problem> GetContextTitleBy(this IQueryable queryable, bool show50Title, int takeProblem)
    //    {
    //        SqlDbContext context = new SqlDbContext();
    //        if (show50Title)
    //        {
    //            return context.Problems.Skip(takeProblem).Take(50);
    //        }
    //        return context.Problems.Skip(takeProblem).Take(10);
    //    }
    //}



}







