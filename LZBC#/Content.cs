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
        protected internal string _kind { get; set; }
        public Content(string kind)
        {
            _kind = kind;
        }
        public User Author { get; set; }
        private DateTime _createTime { get; set; }
        private DateTime _PublishTime;
            public DateTime PublishTime
        {
            get { return _createTime; }
        }

        public void Publish() { }
        DateTime

    }
}
