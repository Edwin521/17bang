using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    interface IEstimate///赞和踩的接口
    {
        public int AgreeAmount { get; set; }
        public int DisagreeAmount { get; set; }

        void AgreedBy(User voter);
        void DisagreeBy(User voter);
    }
}
