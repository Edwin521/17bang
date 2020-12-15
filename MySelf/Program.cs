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

            //将改动同步到数据库
            //Update-Database
            //回退数据库到FailedTry添加之前
            //Update-Database 20201215075910_AddDatabaseAndUser





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







