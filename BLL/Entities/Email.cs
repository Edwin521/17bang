using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Email:BaseEntity
    {
        public string Address { get; set; }
        public bool IsActive { set; get; }
        public DateTime? Expire { set; get; }
        public string Captcha { get; set; }


    }
}
