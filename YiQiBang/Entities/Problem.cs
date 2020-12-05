using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public class Problem:Content
    {
        public Problem():base("求助")
        {
        }
        public int Reward { get; set; }

    }
}
