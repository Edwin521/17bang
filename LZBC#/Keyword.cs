using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class Keyword
    {
        //一个关键字可以对应多篇文章
        public string Content { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
