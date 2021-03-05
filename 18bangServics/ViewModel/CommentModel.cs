using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel
{
   public class CommentModel
    {
        public int Id { get; set; }
        public DateTime PublishTime { get; set; }
        public UserModel Author { get; set; }
        public string Comment { get; set; }
        public CommentModel Reply { get; set; }
        public int BlongArticleId { get; set; }
        public int Agree { get; set; }
        public int DisAgree { get; set; }

    }
}
