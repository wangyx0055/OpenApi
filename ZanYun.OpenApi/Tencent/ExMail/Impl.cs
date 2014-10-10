using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZanYun.OpenApi.Entity;
using ZanYun.OpenApi.Utility;

namespace ZanYun.OpenApi.Tencent.ExMail
{
    public class Impl
    {
        public static TokenEntity Token()
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.TokenUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("Client_ID", AppConfig.Client_ID);
                paramEntity.NVCollection.Add("Client_Secret", AppConfig.Client_Secret);
                paramEntity.NVCollection.Add("Grant_Type", "client_credentials");
                return WebHelper.Post<TokenEntity>(paramEntity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
