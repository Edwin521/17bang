using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()


    public class Problem : Content
    {

        public Problem() : base("求助")///构造函数加上基类的构造函数实现new一个对象的时候他的属性自动赋值
        {

        }
        public List<Comment> comments { get; set; }
        public List<Keyword<Problem>> keywords { get; set; }

        private int _reward;

        public int Reward     //problem.Reward不能为负数
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException();
                }//else nothing
            }
        }



        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。

        private string[] _keywords = new string[10];


        public string this[int index]
        {
            set { _keywords[index - 1] = value; }
            get { return _keywords[index - 1]; }
        }

        public void Load(int Id) { }
        public void Delete(int Id) { }
    }
}
