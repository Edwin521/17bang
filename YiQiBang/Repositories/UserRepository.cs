using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YiQiBang.Entities;

namespace YiQiBang.Repositories
{
    public class UserRepository
    {
        private static IList<User> Users;
        public int UserCount { get; set; } = Users.Count;
        static UserRepository()
        {
            Users = new List<User>() {

            new User
            {
                Id = 1,
                Name="马保国",
                Password="521521",
                Introduction="我会闪电五连鞭，谁与争锋",
              
            },
              new User
            {
                Id = 2,
                Name="马保国2",
                Password="5215212",
                Introduction="我会闪电五连鞭，谁与争锋",
            },
                new User
            {
                Id = 3,
                Name="特朗普",
                Password="521521",
                Introduction="没有人比我更懂法律",
            },
                  new User
            {
                Id = 4,
                Name="赵铁路",
                Password="521521",
                Introduction="我会闪电五连鞭，谁与争锋",
            },
                    new User
            {
                Id = 5,
                Name="杰瑞",
                Password="521521",
                Introduction="我会闪电五连鞭，谁与争锋",
            },

        };
        }

  
        internal int GetMaxId()
        {
            var excellent = Users.OrderByDescending(a => a.Id).First();
            return excellent.Id;
        }

        internal User GetByName(string name)
        {
            return Users.Where(u => u.Name == name).SingleOrDefault();
        }

        //internal void Save(User newUser)
        //{
        //    Users.Add(newUser);
        //}
        public void Save(User user)
        {
            /// <summary>
            /// 1，连接数据库
            /// 2，生成数据库命令，增删改查，command
            /// 3，执行，返回结果
            /// 4，关闭数据库
            /// </summary>
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
                command.CommandText = $"INSERT [User]([NAME],[PASSWORD],[InvitedBy])" +
                    $"VALUES('{user.Name}','{user.Password}','{user.InvitedBy.Id}');";

                command.ExecuteNonQuery();
               
                  
                    
                   
                   
              
                //     int NewRegisterId = helper.Insert(cmd, new SqlParameter[]
                //{
                //     new SqlParameter("@InviteName",user.Inviter),
                //     new SqlParameter("@InvitedCode",user.InviterNumber),
                //     new SqlParameter("@UserName",user.UserName),
                //     new SqlParameter("@Password",user.Password)
                //}

            }

            
      
      

            
        }

        internal IList<User> Get(int pageIndex, int pageSize)
        {
            return Users.Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
        }

        public UserRepository()
        {
         
        }

        public User Find(int id)
        {
            return Users.Where(u => u.Id == id).SingleOrDefault();

        }
        void Delete()
        {

        }
     
    }
}
