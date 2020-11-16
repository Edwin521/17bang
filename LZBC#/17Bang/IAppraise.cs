using System.Collections.Generic;
using System.Text;

namespace LZBC
{
   public interface IAppraise<T> ///赞和踩的接口
    {
        void Agree();
        void Disagree();
    }
}
