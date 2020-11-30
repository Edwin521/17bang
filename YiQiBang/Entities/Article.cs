using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public class Article : Content
    {
        public int Id { get; set; }
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public List<Keyword> keywords{get;set;}
        public List<Comment> Commonts { get; set; }
        public List<Appraise> Appraise { get; set; }
        public int DisagreeAmount { get; set; }
        public int AgreeAmount { get; set; }
    }
}
