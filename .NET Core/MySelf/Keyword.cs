using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
    public class Keyword:BaceEntity
    {
        public string Word { set; get; }
        public IList<Article> Articles { get; set; }
        public IList<Problem> problems { get; set; }
    }
}
