using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
    enum Token
    {
        SuperAdmin,//不写底层数据默认为0
        Admin,
        Blogger,
        Newbie,
        Registered
    }
}
