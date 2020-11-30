using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public class Content
    {
        public String Title { get; set; }
        public string Body { get; set; }
        public string Keyword { get; set; }
        public User Author { get; set; }
        public DateTime CreateTime { get;  set; }

        public DateTime PublishTime { get; set; }
    }
}
