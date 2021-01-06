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
        public UserRepository(DbContext content) : base(content)
        {

        }
        public User GetLogOnInfo(int userId)
        {
            return entities.Include(m => m.Wallet).Where(u => u.Id == userId).FirstOrDefault();
        }
        /// <summary>
        ///  从数据库得到邀请人
        /// </summary>
        public User GetByName(string name)
        {
            return entities.Where(u => u.UserName == name).FirstOrDefault();
        }
        public int AddRegisterToDb(User regiserInfo)
        {
            entities.Add(regiserInfo);
            context.SaveChanges();
            return regiserInfo.Id;
        }
      

    }
}
