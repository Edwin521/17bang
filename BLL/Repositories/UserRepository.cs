using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository:BaseRepository<User>
    {

        public User GetByName( string name) {
            return dbSet.Where(u =>u.Name== name).SingleOrDefault();
        }


        public int Save( User user)
        {
          return dbSet.Add(user).Id;
          
        }

        public User find(int UserId)
        {
            return dbSet.Where(u => u.Id == UserId).SingleOrDefault();
        }
    }
}
