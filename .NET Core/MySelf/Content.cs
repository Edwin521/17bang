using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
    public class Content:BaceEntity
    {
        public string Title { set; get; }
        public string Body { set; get; }
        public string Summary { set; get; }
        public DateTime PublishTime { set; get; }
    }
}
