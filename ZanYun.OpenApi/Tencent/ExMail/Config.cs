using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZanYun.OpenApi.Tencent.ExMail
{
    public class Config
    {
        /// <summary>
        /// 验证授权URL
        /// </summary>
        public const string OAuthUrl = "https://exmail.qq.com/cgi-bin";

        /// <summary>
        /// APIURL
        /// </summary>
        public const string ApiUrl = "http://openapi.exmail.qq.com:12211";

        /// <summary>
        /// OAuth验证授权
        /// </summary>
        public const string TokenUrl = OAuthUrl + "/token";

        /// <summary>
        /// 获取 Authkey
        /// </summary>
        public const string AuthkeyUrl = ApiUrl + "/openapi/mail/authkey";

        /// <summary>
        /// 一键登录
        /// </summary>
        public const string LoginUrl = OAuthUrl + "/login?fun=bizopenssologin&method=bizauth&agent={0}&user={1}&ticket={2}";

        /// <summary>
        /// 客户端维持长连接
        /// </summary>
        public const string ListenUrl = ApiUrl + "/openapi/listen";

        /// <summary>
        /// 获取成员资料
        /// </summary>
        public const string UserGetUrl = ApiUrl + "/openapi/user/get";

        /// <summary>
        /// 同步成员帐号资料
        /// </summary>
        public const string UserSyncUrl = ApiUrl + "/openapi/user/sync";

        /// <summary>
        /// 获取某个版本号后的用户更新列表
        /// </summary>
        public const string UserListUrl = ApiUrl + "/openapi/user/list";

        /// <summary>
        /// 获取未读邮件数
        /// </summary>
        public const string MailNewCountUrl = ApiUrl + "/openapi/mail/newcount";

        /// <summary>
        /// 同步部门
        /// </summary>
        public const string PartySyncUrl = ApiUrl + "/openapi/party/sync";

        /// <summary>
        /// 获取子部门列表
        /// </summary>
        public const string PartyListUrl = ApiUrl + "/openapi/party/list";

        /// <summary>
        /// 获取部门下成员列表
        /// </summary>
        public const string PartyuserListUrl = ApiUrl + "/openapi/partyuser/list";

        /// <summary>
        /// 检查邮件帐号是否可用
        /// </summary>
        public const string UserCheckUrl = ApiUrl + "/openapi/user/check";

        /// <summary>
        /// 添加邮件群组
        /// </summary>
        public const string GroupAddUrl = ApiUrl + "/openapi/group/add";

        /// <summary>
        /// 删除邮件群组
        /// </summary>
        public const string GroupDeleteUrl = ApiUrl + "/openapi/group/delete";

        /// <summary>
        /// 添加邮件群组成员
        /// </summary>
        public const string GroupAddMemberUrl = ApiUrl + "/openapi/group/addmember";

        /// <summary>
        /// 删除邮件群组成员
        /// </summary>
        public const string GroupDeleteMemberUrl = ApiUrl + "/openapi/group/deletemember";

    }
}
