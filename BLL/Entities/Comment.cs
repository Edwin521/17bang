using System;

namespace BLL.Entities
{
    public class Comment:BaseEntity
    {
        public DateTime PublisTime { get; set; }
        public string Content { get; set; }

        public int Agree { get; set; }
        public int DisAgree { get; set; }

        public int? ReplyId { get; set; }
        public Comment Reply { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public int BelongArticleId { get; set; }
        public Article BelongArticle { get; set; }

        public void FillComment(User author)
        {
            this.PublisTime = DateTime.Now;
            this.Author = author;
        }



    }
}