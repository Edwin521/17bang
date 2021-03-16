using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User : BaseEntity
    {
        public string Name { set; get; }
        public string Password { set; get; }
        public int Level { set; get; }
        public int? InviterId { set; get; }
        public User Inviter { set; get; }
        public string MyInviterCode { set; get; }
        public IList<BMoney> Wallet { set; get; }
        public Email Email { get; set; }



        private int getRandomCode()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        public User Register(BMoney bMoney)
        {
            bMoney.OwnerId = this.Id;
            this.Level = 0;
            this.Wallet = new List<BMoney>();
            this.Wallet.Add(bMoney);
            this.MyInviterCode = getRandomInviterNumber();
            return this;

        }

        private String getRandomInviterNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }
    }
}
