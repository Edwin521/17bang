using System.Collections.Generic;

namespace BLL.Entities
{
    public class Keyword
    {
        public string Word { get; set; }
        public int Used { get; set; }
        public IList<Article> Articles { get; set; }
        public IList<Problem> Problems { get; set; }

        #region 取到关键字
        public IList<Keyword> GetKeyWordslist(string keyword)
        {
            IList<Keyword> tempKeywordList = new List<Keyword>();
            if (!string.IsNullOrEmpty(keyword))
            {
                string[] temp = keyword.Trim().Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(temp[i]))
                    {
                        tempKeywordList.Add(new Keyword { Word = temp[i] });
                    }
                }
            }
            return tempKeywordList;
        }
        #endregion

        #region 
        public Keyword AddUsed( Keyword item)
        {
           item.Used++;
            return item;
        }
        #endregion

        #region 
        public Keyword AddNewKeyword(Keyword keyword)
        {
            return new Keyword
            {
                Word = keyword.Word,
                Used = ++keyword.Used
            };
        }
        #endregion

    }
}