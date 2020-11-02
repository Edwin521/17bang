using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
   
    public class Article : Content
    {
        public Article() : base("文章")///构造函数加上基类的构造函数实现new一个对象的时候他的属性自动赋值
        {

        }
        public string[] Comment { get; set; }
        public void PraiseBy( User UserName) //赞和踩都会增减作者及评价者的帮帮点。
        {
            UserName.HelpDot++;
            Author.HelpDot++;
            
        } 
        public void treadBy(User UserName)
        {
            Author.HelpDot--;
            UserName.HelpDot++;
        }

        //internal override void publish()
        //{
        //    helpMoneny--;//消耗一个帮帮币

        //    Console.WriteLine("存入到数据库");
        //}

    }
}
