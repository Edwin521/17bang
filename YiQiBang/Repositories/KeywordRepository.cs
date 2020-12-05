using YiQiBang.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Repositories
{
    public class KeywordRepository
    {
        private static IList<Keyword> keywords;
        static KeywordRepository()
        {
            keywords = new List<Keyword>()
            {
                 new Keyword
                {
                    Word = "编程开发语言",
                    Id = 1,
                    Used = 52,
                    SecendKeyword = new List<SecendKeyword>
                    {
                        new SecendKeyword{Word = "C#",Id = 1 ,Used = 42},
                        new SecendKeyword{Word = "Java",Id = 2,Used = 21},
                        new SecendKeyword{Word = "Javascript",Id = 3,Used = 32},
                        new SecendKeyword{Word = "Html",Id = 4,Used = 32 },
                        new SecendKeyword{Word = "SQL",Id = 5 ,Used = 32},
                        new SecendKeyword{Word = "Python",Id = 6,Used = 32},
                        new SecendKeyword{Word = "CSS",Id = 7,Used = 32},
                        new SecendKeyword{Word = "PHP",Id = 8,Used = 32}
                    },
                    SelfDefined = new List<Keyword>{}
                 },
                  new Keyword
                {
                    Word = "工具软件",
                    Id = 2,
                    Used = 32,
                    SecendKeyword = new List<SecendKeyword>
                    {
                        new SecendKeyword{Word = "VisualStudio",Id = 1,Used = 32 },
                        new SecendKeyword{Word = "eclipse",Id = 2,Used = 32},
                        new SecendKeyword{Word = "IDEA",Id = 3,Used = 32},
                        new SecendKeyword{Word = "Excel",Id = 4 ,Used = 32},
                        new SecendKeyword{Word = "Word",Id = 5 ,Used = 32},
                        new SecendKeyword{Word = "CAD",Id = 6,Used = 32},
                        new SecendKeyword{Word = "Photoshop",Id = 7,Used = 32},
                        new SecendKeyword{Word = "PowerPoint",Id = 8,Used = 32}
                    },
                    SelfDefined = new List<Keyword>{}
                },
                new Keyword
                {
                    Word = "顾问咨询",
                    Id = 3,
                    Used = 56,
                    SecendKeyword = new List<SecendKeyword>
                    {
                        new SecendKeyword{Word = "职场",Id = 1 ,Used = 32},
                        new SecendKeyword{Word = "法律",Id = 2,Used = 32},
                        new SecendKeyword{Word = "财务",Id = 3,Used = 32},
                        new SecendKeyword{Word = "心理",Id = 4 ,Used = 32},
                        new SecendKeyword{Word = "亲子",Id = 5 ,Used = 32},
                        new SecendKeyword{Word = "婚姻家庭",Id = 6,Used = 32}
                    },
                    SelfDefined = new List<Keyword>{}
                },
                new Keyword
                {
                    Word = "操作系统",
                    Id = 4,
                    Used = 58,
                    SecendKeyword = new List<SecendKeyword>
                    {
                        new SecendKeyword{Word = "Linux",Id = 1 ,Used = 32},
                        new SecendKeyword{Word = "Windows",Id = 2,Used = 32},
                        new SecendKeyword{Word = "Android",Id = 3,Used = 32},
                        new SecendKeyword{Word = "Unix",Id = 4 ,Used = 32},
                    },
                    SelfDefined = new List<Keyword>{}
                }

            };
        }

        internal List<Keyword> Find(int id)
        {
            return keywords.Take(id).ToList();
        }
    }
}
