using System;
using System.Collections.Generic;
using System.Text;

namespace MySelf
{
   public  class Kind :BaceEntity
    {
        public string Name { set; get; }
        public IList<Problem> ThisProblem { set; get; }
    }
}
