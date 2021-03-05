

namespace YiQiBang.Entities
{
    public class Comment: Content
    {
        public Comment() : base("评论")///构造函数加上基类的构造函数实现new一个对象的时候他的属性自动赋值
        {

        }
       
        //public IList<Appraise> Appraises { get; set; }
        public Article Article { get; set; }

        public Comment comment { get; set; }
   
        public int DisagreeAmount { get; set; }
        public int AgreeAmount { get; set; }
    }
}