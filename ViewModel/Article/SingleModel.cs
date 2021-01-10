using _18bangServices.ViewModel.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel.Article
{
   public class SingleModel
    {
        public int Id { set; get; }
        public string AuthorName { set; get; }

        public string Title { set; get; }
     
        public string Body { set; get; }

        public DateTime PublishTime { get; set; }

        public string ChoosSeries { set; get; }
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }
   
        public IList<KeywordModel> KeywordList { get; set; }
        public IList<CommentModel> Comments { set; get; }



        public int SeriesId { set; get; }
        public string SeriesTitle { set; get; }

        public int LastArticleId { set; get; }
        public string LastArticleTitle { set; get; }

        public int NextArticleId { set; get; }
        public string NextArticleTitle { set; get; }
    }
}
