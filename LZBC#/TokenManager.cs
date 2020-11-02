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
        private Token _tokens { get; set; }

        public Token Add(Token Token)
        {

            return this._tokens | Token;

        }

        public Token Remove(Token Token)
        {

            return this._tokens ^ Token;

        }

        public bool Has(Token Token)
        {
            return (this._tokens & Token) == Token;

        }


    }
}
