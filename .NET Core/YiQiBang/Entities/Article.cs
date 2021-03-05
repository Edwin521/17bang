using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public class Article : Content
    {

        //zushi
        public Article() : base("文章")
        {

        }
        public List<Keyword> keywords { get; set; }
        public List<Comment> Commonts { get; set; }
        public List<Appraise> Appraise { get; set; }
        public int DisagreeAmount { get; set; }
        public int AgreeAmount { get; set; }


        public void DisagreeBy(User voter)
        {
            Author.HelpDot++;
            voter.HelpDot++;
            DisagreeAmount++;
        }

      
        public void AgreedBy(User voter) //赞和踩都会增减作者及评价者的帮帮点。
        {
            voter.HelpDot++;
            Author.HelpDot++;
            AgreeAmount++;
        }
        public override void Publish()
        {
            PublishTime = DateTime.Now;
            Author.HelpMoney--;//消耗一个帮帮币g

            Console.WriteLine("存入到数据库");

        }

    }
}
