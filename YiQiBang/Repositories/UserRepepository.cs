using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YiQiBang.DbHelp;
using YiQiBang.Entities;

namespace YiQiBang.Repositories
{
    public class UserRepepository
    {
        private static IList<User> Users;
        public int UserCount { get; set; } = Users.Count;
        private string connectionString =
           @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog=18bang;Integrated Security=True;";
        //static UserRepository()
        //{
        //    Users = new List<User>() {

        //    new User
        //    {
        //        Id = 1,
        //        Name="马保国",
        //        Password="521521",
        //        Introduction="我会闪电五连鞭，谁与争锋",

        //    },
        //      new User
        //    {
        //        Id = 2,
        //        Name="马保国2",
        //        Password="5215212",
        //        Introduction="我会闪电五连鞭，谁与争锋",
        //    },
        //        new User
        //    {
        //        Id = 3,
        //        Name="特朗普",
        //        Password="521521",
        //        Introduction="没有人比我更懂法律",
        //    },
        //          new User
        //    {
        //        Id = 4,
        //        Name="赵铁路",
        //        Password="521521",
        //        Introduction="我会闪电五连鞭，谁与争锋",
        //    },
        //            new User
        //    {
        //        Id = 5,
        //        Name="杰瑞",
        //        Password="521521",
        //        Introduction="我会闪电五连鞭，谁与争锋",
        //    },

        //};
        //} 


        internal int GetMaxId()
        {
            var excellent = Users.OrderByDescending(a => a.Id).First();
            return excellent.Id;
        }


        public User GetByName(string name)
        {
            User user = new User();
            user.InvitedBy = new User();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = $"SELECT * FROM [USER] WHERE NAME ='{name}';";
                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user.Name = reader["NAME"].ToString();
                    user.Password = reader["PASSWORD"].ToString();
                    user.Id = Convert.ToInt32(reader["ID"]);
                    user.InvitedBy.Id = Convert.ToInt32(reader["InvitedBy"]);
                }
                else
                {
                    return null;
                }

            }

            return user;

        }

        public bool Save(User user)
        {
            //DbHelper helper = new DbHelper();
            //#region Insert Register
            //string cmd =
            //    @"Insert [User](InviteName,InvitedCode,UserName,[Password],InviteById,[Level])
            //    Values(@InviteName, @InvitedCode, @UserName, @Password,(Select Id From[User] Where UserName = @InviteName),1) ";
            //int newRegisterId = helper.Insert(cmd, new SqlParameter[]
            //{
            //    new SqlParameter("@InviteName",user.InvitedBy),
            //    new SqlParameter("@InvitedCode",user.InviteCode),
            //    new SqlParameter("@UserName",user.Name),
            //    new SqlParameter("@Password",user.Password)
            //});


            return true;
        }

        internal IList<User> Get(int pageIndex, int pageSize)
        {
            return Users.Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
        }

        public UserRepepository()
        {

        }



        public User Find(int id)
        {
            User user = new User();
            user.InvitedBy = new User();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = $"SELECT * FROM [USER] WHERE ID = {id}";
                IDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.Name = reader["NAME"].ToString();
                    user.Password = reader["PASSWORD"].ToString();
                    user.InvitedBy.Id = Convert.ToInt32(reader["InvitedBy"]);
                }
                else
                {
                    user = null;
                }

            }

            return user;
        }


    }
}
