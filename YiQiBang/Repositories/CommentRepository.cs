using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YiQiBang.Entities;

namespace YiQiBang.Repositories
{

    public class CommentRepository
    {
        private static IList<Comment> comments;

        static CommentRepository()
        {
            UserRepepository userRepository = new UserRepepository();
            comments = new List<Comment>()
            {
                new Comment{
                    Id=1,
                    Body="我会闪电五连鞭",
                    PublishTime = new DateTime(2019, 1, 21, 1, 1, 1),
                    DisagreeAmount = 1120, AgreeAmount = 10,
                    Author =userRepository.Find(1),
                },
                new Comment{
                    Id=2,
                    Body="我会闪电五连鞭",
                    PublishTime = new DateTime(2019, 1, 21, 1, 1, 1),
                    DisagreeAmount = 1120, AgreeAmount = 10,
                    Author =userRepository.Find(4),
                },
                 new Comment{
                    Id=3,
                    Body="我会闪电五连鞭",
                    PublishTime = new DateTime(2019, 1, 21, 1, 1, 1),
                    DisagreeAmount = 1120, AgreeAmount = 10,
                    Author =userRepository.Find(2),
                }
            };
        }

        internal List<Comment> Find(int id)
        {
            return comments.Take(id).ToList();
        }
    }
}
