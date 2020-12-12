using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YiQiBang.Entities;
using YiQiBang.Repositories;

namespace YiQiBang.Pages.Message
{
    [BindProperties]
    public class MineModel : PageModel
    {
        public Entities.User UserInfo { set; get; }
        public IList<Keyword> Keyword { set; get; }

        public int SumOfArticle { set; get; }
        public IList<MessageMine> Messages { set; get; }

        private MessageRepository messageRepository;
        public MineModel()
        {
            messageRepository = new MessageRepository();
        }
        public bool CheckAll { set; get; }
       public const int pagesize = 10;
        public int PageCount { get; set; }
        public void OnGet()
        {
            
            int pageIndex = Convert.ToInt32(Request.RouteValues["id"]);
            Messages = messageRepository.Get();
            SumOfArticle = messageRepository.GetSum();
            PageCount = SumOfArticle / pagesize;
            if (SumOfArticle % 2 == 1)
            {
                ++SumOfArticle;
            }
            Messages = messageRepository.GetPaged(pageIndex, pagesize);

          
            foreach (var item in Messages)
            {
                if (!item.HasRead)
                {
                    HttpContext.Response.Cookies.Append("HasUnreadMessage", "true");
                    break;
                }
                else
                {
                    HttpContext.Response.Cookies.Delete("HasUnreadMessage");
                }
            }
        }

        public void OnPost()
        {

        }
    }
}