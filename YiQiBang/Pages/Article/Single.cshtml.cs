using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YiQiBang.Repositories;
using E = YiQiBang.Entities;

namespace YiQiBang.Pages.Article
{
    public class SingleModel : PageModel
    {
        private ArticleRepository articleRepository;
        public SingleModel()//在构造函数里给art..实例化
        {
            articleRepository = new ArticleRepository();
        }
        public E.Article Article { get; set; }
        public E.Article PreviousPage { get; set; }
        public E.Article NextPage { get; set; }
  
        public void OnGet()
        {
            //int id = Convert.ToInt32(Request.Query["Id"]);
            int id = Convert.ToInt32(RouteData.Values["id"]);


            Article = articleRepository.Find(id);
            PreviousPage= articleRepository.Find(id-1);
            NextPage= articleRepository.Find(id + 1);
           
        }
    }
}