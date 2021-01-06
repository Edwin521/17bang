using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User : BaseEntity
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public int Level { set; get; }
        public int? InviterId { set; get; }
        public User Inviter { set; get; }
        public int MyInviterCode { set; get; }
        public IList<BMoney> Wallet { set; get; }


        public User Register(User newUser, BMoney award)
        {
            award.OwnerId = newUser.Id;
            newUser.Level = 0;
            newUser.Wallet = new List<BMoney>();
            newUser.Wallet.Add(award);
            newUser.MyInviterCode = getRandomCode();
            return newUser;
          
                
        }

        private int getRandomCode()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
