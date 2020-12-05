using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public abstract class Content:Entity
    {

        public Content(string kind)
        {
            CreateTime = DateTime.Now;
            this.kind = kind;
        }

        protected internal string kind { get; set; }

        public int HelpMoney { set; get; }

        [Required(ErrorMessage = "标题不能为空")]
        public String Title { get; set; }
        [Required(ErrorMessage = "内容不能为空")]
        public string Body { get; set; }
        public string Keyword { get; set; }
        public User Author { get; set; }
        public DateTime CreateTime { get;  set; }

        public DateTime PublishTime { get; set; }

        public virtual void Publish()
        {
           
        }
    }
}
