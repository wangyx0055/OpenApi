using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZanYun.OpenApi.Tencent.ExMail
{
    public class Entity
    {
    }

    public class TokenEntity
    {
        public string Access_Token { get; set; }

        public string Token_Type { get; set; }

        /// <summary>
        /// access_token 的有效使用期，失效后请重新获取
        /// </summary>
        public int Expires_In { get; set; }

        public string Refresh_Token { get; set; }

    }
}
