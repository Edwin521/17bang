using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YiQiBang.Pages.Message;

namespace YiQiBang.Repositories
{
    public class MessageRepository
    {

        private static IList<MessageMine> messages;
        static MessageRepository()
        {
            messages = new List<MessageMine>
            {
                new MessageMine
                {
                    Id = 1,
                    PublishTime = DateTime.Now.AddDays(-5),
                    Content = "你因为登录获得系统随机分配给你的 帮帮豆 14 枚，可用于感谢赞赏等。 ",
                    HasRead = false,
                    HasCheck = false,
                    Status=MessageStatus.Refresh,
                },
            };
        }
        internal void Remove(int id)
        {
            messages.Remove(messages.Where(m => m.Id == id).Single());
        }

        public MessageMine GetHasRead(int id)
        {
            return messages.Where(m => m.Id == id).Single();
        }

        public IList<MessageMine> Get()
        {
            return messages;
        }
        public void Add(MessageMine value)
        {
            messages.Add(value);
        }
    

        public int GetSum()
        {
            return messages.Count;
        }
        internal IList<MessageMine> GetPaged(int pageIndex, int pageSize)
        {
            return messages.Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
        }
    }
}
