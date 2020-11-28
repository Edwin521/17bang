using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YiQiBang.Repositories;
using E= YiQiBang.Entities;

namespace YiQiBang.Pages.Article
{
    public class IndexModel : PageModel
    {
        private ArticleRepository articleRepository;
        public IndexModel()//在构造函数里给art..实例化
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> Articles { get; set; }





        public void OnGet()
        {
            Articles = articleRepository.Get(1);
        }
    }
}