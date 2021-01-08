using _18bangServices.ViewModel.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel
{
  public class ArticleItemModel
    {
        public int Id { set; get; }

        public string AuthorName { set; get; }

        public int Level { set; get; }

        public int AuthorId { set; get; }

        public string Title { set; get; }

        public string Body { set; get; }

        public string Summary { set; get; }

        public DateTime PublishTime { get; set; }
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }

        public IList<KeywordModel> KeywordList { get; set; }
        public IList<CommentModel> CommentsList { get; set; }

        
    }
}
