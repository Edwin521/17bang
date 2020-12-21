using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MySelf
{
    public class human
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
            SqlDbContext context = new SqlDbContext();
            //User user = new User
            //{
            //    Id=1,
            //    Name = "周丁浩",
            //    IsFamle = "true",
            //};
            //context.Users.Add(user);
            //context.SaveChanges();


            //使用EF的API直接建库建表删库
            var db = context.Database;
            //db.EnsureDeleted();
            //db.EnsureCreated();
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

            //new ProblemRepository().GetBy(new List<ProblemStatus> { new ProblemStatus { } }, false, false);

            //EF：关联对象：映射和加载作业
            //观察一起帮的功能，思考并
            //Email和User有一对一的关系，参照课堂演示，在数据库上建立User外键引用Email的映射


            User lzb = new User { Name = "lzb", Password = "1234" };
            Email email = new Email { EmailLocation = "123456@qq.com" };
            lzb.SendTo = email;
            email.FromWho = lzb;

            context.Add<User>(lzb);
            context.Add<Email>(email);
            context.SaveChanges();
            //按继承映射：Blog / Article / Suggest以及他们的父类Content



            // EF core：事务和UoW作业
            //用事务实现帮帮币出售的过程
            //卖方帮帮币足够，扣减数额后成功提交。
            // 卖房帮帮币不够，事务回滚，买卖双方帮帮币不变。

        }
    }



    class students /*: IEnumerable*////实现IEnumerable接口就可以躲过编译时检查，不报错，但运行时会报错
    {                            ///不写后面这个接口名也没事，只要在类中实现了GetEnumerator()方法就可以了


        //public class StudentsEnumerator : IEnumerator  ///类中类实现返回一个
        //{
        //    public object[] ages = new object[] { 12, 34, 56, 75, 332 };
        //    private int index = -1;
        //    public object Current
        //    {
        //        get
        //        {
        //            return ages[index];
        //        }
        //    }

        //    public bool MoveNext()
        //    {
        //        index++;
        //        return index < ages.Length;
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    return new StudentsEnumerator();
        //}
    }
}







