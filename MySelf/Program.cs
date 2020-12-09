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
            string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog=18bang;Integrated Security=True;";
            //IDbConnection connection = new SqlConnection(connectionString);//生成一个connection对象
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                //command.CommandText = @"Insert [User]([Name],[Password],InviteById,InvitedCode)
                //Values(@UserName,@Password,@InviteName, @InvitedCode,
                //(Select Id From[User] Where UserName = @InviteName)) ";
                command.CommandText = $"INSERT [User]([NAME],[PASSWORD],[InvitedBy])VALUES(N'周丁浩',N'4567',3);";

                command.ExecuteNonQuery();

            }

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







