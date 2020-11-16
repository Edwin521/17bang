using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    class DBMessage : ISendMessage
    {
        public void Send(User receiver)
        {
            Console.WriteLine("发送消息");
        }
    }
}
