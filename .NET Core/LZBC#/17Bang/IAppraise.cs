using System.Collections.Generic;
using System.Text;

namespace LZBC
{
   public interface IAppraise ///赞和踩的接口
    {
        void Agree(User voter);
        void Disagree(User voter );
    }
}
