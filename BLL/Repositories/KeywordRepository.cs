using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class KeywordRepository : BaseRepository<Keyword>
    {
        public KeywordRepository(SqlDbContext context) : base(context)
        {
        }

        public Keyword GetByKeyword(Keyword item)
        {
            return dbSet.Where(k => k.Word == item.Word).FirstOrDefault();
        }

        public int UpdateKeywordUsed(Keyword Item)
        {
            dbSet.Attach(Item);
            return Item.Id;
        }


        public IList<Keyword> GetLevelKeywords(bool firstKeyword) {
            if (firstKeyword)
            {
                return dbSet.Where(k => k.LevelId == 1).ToList();
            }
            return dbSet.Where(k => k.LevelId == 2).ToList();
        }


    }
}
