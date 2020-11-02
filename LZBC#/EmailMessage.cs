using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    class EmailMessage : ISendMessage
    {
        public void Send(User receiver)
        {
            Console.WriteLine("发送Email");
        }
    }
}
