using System;
using System.Collections.Generic;
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
                IsMale=true,
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

        internal void Save(User newUser)
        {
            Users.Add(newUser);
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

        public User find(int id)
        {
            return Users.Where(u => u.Id == id).SingleOrDefault();

        }
        void Delete()
        {

        }
     
    }
}
