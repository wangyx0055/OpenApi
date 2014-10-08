using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZanYun.OpenApi.Utility
{
    public class WebHelper
    {
        /// <summary>
        /// 模拟POST提交
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="postParam">参数</param>
        /// <returns></returns>
        public static T Post<T>(Entity.ParamEntity postParam)
        {
            try
            {
                string stringInfo = Post(postParam);
                if (!string.IsNullOrEmpty(stringInfo))
                {
                    return JsonConvert.DeserializeObject<T>(stringInfo);
                }
                else
                {
                    return default(T);
                }
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 模拟POST提交
        /// </summary>
        /// <param name="postParam">参数</param>
        /// <returns></returns>
        public static string Post(Entity.ParamEntity postParam)
        {
            WebClient webClient = new WebClient();
            try
            {
                if (!string.IsNullOrEmpty(postParam.Headers))
                {
                    webClient.Headers.Add(postParam.Headers);
                }
                byte[] byteInfo = webClient.UploadValues(postParam.Url, "POST", postParam.NVCollection);
                string stringInfo = System.Text.Encoding.UTF8.GetString(byteInfo);
                return stringInfo;
            }
            catch
            {
                return null;
            }
        }
    }
}
