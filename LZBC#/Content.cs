using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
    //1Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
    //2确保每个Content对象都有kind的非空值
    //3Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
    //4其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。


    public class Content
    {
        //确保文章的标题不能为null值，也不能为一个或多个空字符组成的字符串，而且如果标题前后有空格，也予以删除
        private string _title;
        public string Title
        {
            
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("标题输入有误，请您重新输入");
                    return;
                }
                else
                {
                    _title = value.Trim();
                }
            }
        }
        public String KeyWord { get; set; }
        public string Main { get; set; }
        protected internal string kind { get; set; }
        public Content(string kind)
        {
            this.kind = kind;
        }
        public User Author { get; set; }
        private DateTime CreateTime { get; set; }

        public DateTime PublishTime => CreateTime;

        public virtual void Publish() { }


    }
}
