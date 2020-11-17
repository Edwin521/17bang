using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class Keyword<T>
    {
        //一个关键字可以对应多篇文章
        public string Word { get; set; }
        public IList<T> Articles { get; set; }
    }
}
