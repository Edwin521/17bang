using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : BaseRepository<User>
    {


        public UserRepository(SqlDbContext context) : base(context)
        {

        }
        public User GetByName(string name)
        {
            return dbSet.Where(u => u.Name == name).SingleOrDefault();
        }


        public int Save(User user)
        {
            dbSet.Add(user);
            context.SaveChanges();
            return user.Id;
        }   

        public User Find(int UserId)
        {
            return dbSet.Find(UserId);
        }

        public User FindByEmail(string email)
        {
            return dbSet.Where(u => u.Email.Address == email).FirstOrDefault();
        }

        public void Update(User user)
        {
            dbSet.Attach(user);
            context.SaveChanges();
        }

        public User FindUserCaptcha(string captcha)
        {
            return dbSet.Where(u => u.Email.Captcha == captcha).FirstOrDefault();
        }
    }
}
