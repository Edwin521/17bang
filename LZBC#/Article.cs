using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    public class Article : Content, IEstimate
    {

        //User类中添加一个Tokens属性，类型为TokenManager

        public TokenManager Tokens { get; set; } = Token.Admin;
        public Article() : base("文章")///构造函数加上基类的构造函数实现new一个对象的时候他的属性自动赋值
        {

        }

        public int AgreeAmount { get; set; }
        public int DisagreeAmount { get; set; }
        public string[] Comment { get; set; }
        public void AgreedBy(User voter) //赞和踩都会增减作者及评价者的帮帮点。
        {
            voter.HelpDot++;
            Author.HelpDot++;
            AgreeAmount++;
        }
        public void DisagreeBy(User voter)
        {
            Author.HelpDot++;
            voter.HelpDot++;
            DisagreeAmount++;
        }

        public override void Publish()
        {
            Author.HelpMoney--;//消耗一个帮帮币g

            Console.WriteLine("存入到数据库");
        }

    }
}
