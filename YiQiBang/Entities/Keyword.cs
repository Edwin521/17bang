using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public class Keyword<T>
    {
        public  IList<T> Word { get; set; }
        public List<T> Articles { get; set; }
    }
}
