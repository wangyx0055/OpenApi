using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZanYun.OpenApi.Entity
{
    public class ParamEntity
    {
        /// <summary>
        /// 提交URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 参数集
        /// </summary>
        public NameValueCollection NVCollection { get; set; }

        /// <summary>
        /// 头信息
        /// </summary>
        public string Headers { get; set; }
    }
}
