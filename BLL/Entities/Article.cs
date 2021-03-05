using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Article : BaseEntity
    {
        public string Summary { get; set; }//文章页只显示单篇文章前三行的内容
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishTime { get; set; }
        public User Author { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public IList<Comment> Comments { get; set; }

        public void PublishArticle()
        {
            this.PublishTime = DateTime.Now;

        }

        ///文章页面只显示单篇文章前几行的内容
        public string GetSummary(string Articlebody)
        {
            string summary = string.Empty;
            if (string.IsNullOrEmpty(summary))
            {
                summary = Articlebody.PadRight(250).Substring(0, 250).Trim();
            }
            else
            {
                summary = summary.Trim();
                if (summary.Length>250)
                {
                    summary = summary.Substring(0, 250);
                }//else nothing 
            }
            return summary;
        }
    }
}
