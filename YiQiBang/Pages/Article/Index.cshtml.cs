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
        public int PageCount { get; set; }
        public const int PageSize = 2;
        public void OnGet()
        {
            int pageIndex =Convert.ToInt32(Request.Query["pageIndex"][0]);//后台拿到数据

            PageCount = articleRepository.ArticleCount/PageSize;
            Articles = articleRepository.Get(pageIndex,PageSize);
        }
    }
}