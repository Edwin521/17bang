using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public interface ISendMessage
    {
        void Send( User receiver);
    }
}
