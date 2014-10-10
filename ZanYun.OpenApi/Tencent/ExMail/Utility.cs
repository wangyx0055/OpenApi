using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZanYun.OpenApi.Tencent.ExMail
{
    public class Utility
    {
        public static string GetTokenHeaders(string Token_Type, string Access_Token)
        {

            return string.Format("Authorization: {0} {1}", Token_Type, Access_Token);
        }
    }
}
