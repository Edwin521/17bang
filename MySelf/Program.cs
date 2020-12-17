using System;
using System.Collections;
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
            db.EnsureCreated();
            db.EnsureDeleted();

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
            //CreateTime不能小于2000年1月1日

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







