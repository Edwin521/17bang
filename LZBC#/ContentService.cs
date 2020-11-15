using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class ContentService
    {
        public void Publish(Content content)
        {
            content.Publish();
            Console.WriteLine("存入数据库");
        }
    }
}
