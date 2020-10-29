using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()


    public class problem
    {
        public string _title { get; set; }
        private string _body { get; set; }
        private int _reward; 
        public DateTime _publishDateTime { get; set; }
        public int _author { get; set; }

        public problem(string body) //每一个Problem对象一定有Body赋值
        {
            _body = body;
        }

        private problem()
        {
        }


        public int Reward     //problem.Reward不能为负数
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("悬赏数不能为负数");
                    return;
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

        //考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：

        ///求助中

        //Publish()：发布一篇求助，并将其保存到数据库
        //Load(int Id)：根据Id从数据库获取一条求助
        //Delete(int Id)：根据Id删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等




        //public int Publish()
        //{
        //}
        public void Load(int Id) { }
        public void Delete(int Id) { }
    }
}
