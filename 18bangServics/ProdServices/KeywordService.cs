using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdServices
{
    public class KeywordService:BaseService
    {
        private Keyword keywordEntity;
        private KeywordRepository keywordRepository;
        public KeywordService()
        {
            keywordEntity = new Keyword();
            keywordRepository = new KeywordRepository(Context);
        }

        public void SaveKeywords(string needSaveKeyword) {
            IList<Keyword> keywords = new Keyword().GetKeyWordslist(needSaveKeyword);
            foreach (var item in keywords)
            {
                keywordEntity = keywordRepository.GetByKeyword(item);
                if (keywordEntity==null)
                {
                    keywordEntity = new Keyword().AddNewKeyword(item);
                    keywordRepository.Save(keywordEntity);
                }
                else
                {
                    keywordEntity = keywordEntity.AddUsed(item);
                    keywordRepository.UpdateKeywordUsed(keywordEntity);
                }
            }
        }



    }
}
