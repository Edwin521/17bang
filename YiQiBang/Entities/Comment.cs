

namespace YiQiBang.Entities
{
    public class Comment: Content
    {
  
        public string content { get; set; }
        //public IList<Appraise> Appraises { get; set; }
        public Article Article { get; set; }

        public Comment comment { get; set; }
        public string main { get; set; }
        public int DisagreeAmount { get; set; }
        public int AgreeAmount { get; set; }
    }
}