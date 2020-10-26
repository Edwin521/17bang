using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()

   
    public class problem
    {
        private string _title { get; set; }
        private string _body { get; set; }

        public problem(string body) //每一个Problem对象一定有Body赋值
        {
            _body = body;
        }

        private problem()
        {
        }

        private int _reward; //problem.Reward不能为负数
        public int _Reward
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("悬赏数不能为负数");
                    return;
                }
            }
        }

        private DateTime _publishDateTime { get; set; }
        private int _author { get; set; }

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。

        private string[] _keywords =new string[10];

        //public problem( int length)
        //{
        //    _keywords = new string[length];
        //}
        public string this[int index]
        {
            set { _keywords[index - 1] = value; }
            get { return _keywords[index - 1]; }
        }

       

        //public bool Publish( )
        //{
        //}
    }
}
