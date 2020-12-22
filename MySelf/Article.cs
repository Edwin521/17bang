using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
    public class Article : Content
    {
        public string AuthorId { set; get; }
        public User Author { set; get; }
        public IList<Keyword> keywords { get; set; }
  
    }
}
