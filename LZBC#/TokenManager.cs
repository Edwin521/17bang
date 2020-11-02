using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    // 声明一个令牌管理（TokenManager）类：

    //使用私有的Token枚举_tokens存储所具有的权限
    //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限

    class TokenManager
    {
        public Token _token { get; set; }

        public void Add(Token Token)
        {

           return new TokenManager()._token|Token.Newbie
        }

        public void Remove(Token Token)
        {



        }

        public void Has(Token Token)
        {



        }


    }
}
