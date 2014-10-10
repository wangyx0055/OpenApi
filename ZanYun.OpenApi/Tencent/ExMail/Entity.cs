using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZanYun.OpenApi.Tencent.ExMail
{
    public class AuthkeyEntity
    {
        public string Auth_Key { get; set; }
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

    public class UserEntity
    {
        /// <summary>
        /// 帐号名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别：0=未设置，1=男，2=女
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// 别名列表，用逗号分隔
        /// </summary>
        public string SlaveList { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string ExtId { get; set; }

        /// <summary>
        /// 成员状态：1=启用，2=禁用
        /// </summary>
        public string OpenType { get; set; }

        /// <summary>
        /// 部门列表，部门的根结点不包括在路径里面。比如部门所属：腾讯/广州研发中心/企业邮箱，Value 为：广州研发中心/企业邮箱
        /// </summary>
        public PartyEntity PartyList { get; set; }

    }

    public class PartyEntity
    {
        public int Count { get; set; }

        public List<PartyNameEntity> List { get; set; }
    }

    public class PartyNameEntity
    {
        public string Value { get; set; }
    }

    public class UserVerListEntity
    {
        /// <summary>
        /// 最新版本号；初始=0 表示获取全部帐号
        /// </summary>
        public string Ver { get; set; }

        /// <summary>
        /// 成员个数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 成员帐号列表
        /// </summary>
        public List<UserVerEntity> List { get; set; }

    }

    public class UserVerEntity
    {
        /// <summary>
        /// 更新动作类型，1=Add, 2=Edit,3=Del
        /// </summary>
        public int Action { get; set; }

        /// <summary>
        /// 帐号名
        /// </summary>
        public string Alias { get; set; }
    }

    public class MailNewCount
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 新邮件数
        /// </summary>
        public int NewCount { get; set; }

    }

    public class PartyUserEntity
    {
        public int Count { get; set; }

        public List<AilasEntity> List { get; set; }
    }

    public class AilasEntity
    {
        public string Value { get; set; }
    }
}
