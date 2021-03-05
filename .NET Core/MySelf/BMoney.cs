using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
   public class BMoney:BaceEntity
    {
      
        public string Detail { set; get; }//详情
        public DateTime LatesTime { set; get; }
        public string OwnerName { set; get; }
        public User Owner { set; get; }
        public int LeftBMoney { set; get; }
        public int LeftBPoint { set; get; }
        public int FreezingMoney { set; get; }
    }
}
