using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
   public  class Email:BaceEntity
    {
        public string EmailLocation { set; get; }
        public string Remark { set; get; }
        public User FromWho { set; get; }
    }
}
