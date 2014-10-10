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
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="Client_ID">申请时账号</param>
        /// <param name="Client_Secret">接口key</param>
        /// <returns></returns>
        public static TokenEntity Token(string Client_ID, string Client_Secret)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.TokenUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("Client_ID", Client_ID);
                paramEntity.NVCollection.Add("Client_Secret", Client_Secret);
                paramEntity.NVCollection.Add("Grant_Type", "client_credentials");
                return WebHelper.Post<TokenEntity>(paramEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取Authkey
        /// </summary>
        /// <param name="tokenEntity">Token实体</param>
        /// <param name="Alias">邮箱账号</param>
        /// <returns></returns>
        public static string Authkey(TokenEntity tokenEntity, string Alias)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.AuthkeyUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("Alias", Alias);
                paramEntity.Headers = Utility.GetTokenHeaders(tokenEntity.Token_Type, tokenEntity.Access_Token);
                return WebHelper.Post<AuthkeyEntity>(paramEntity).Auth_Key;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 返回一键登录地址
        /// </summary>
        /// <param name="Client_ID">申请时账号</param>
        /// <param name="Alias">登录邮箱</param>
        /// <param name="Authkey">Authkey</param>
        /// <returns></returns>
        public static string Login(string Client_ID, string Alias, string Authkey)
        {
            return string.Format(UrlsConfig.LoginUrl, Client_ID, Alias, Authkey);
        }

        /// <summary>
        /// 获取成员资料
        /// </summary>
        /// <param name="tokenEntity">Token实体</param>
        /// <param name="Alias">邮箱账号</param>
        /// <returns></returns>
        public static UserEntity UserGet(TokenEntity tokenEntity, string Alias)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.UserGetUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("Alias", Alias);
                paramEntity.Headers = Utility.GetTokenHeaders(tokenEntity.Token_Type, tokenEntity.Access_Token);
                return WebHelper.Post<UserEntity>(paramEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取某个版本号后的用户更新列表
        /// </summary>
        /// <param name="tokenEntity">Token实体</param>
        /// <param name="Ver">版本号</param>
        /// <returns></returns>
        public static UserVerListEntity UserVerList(TokenEntity tokenEntity, string Ver)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.UserListUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("Ver", Ver);
                paramEntity.Headers = Utility.GetTokenHeaders(tokenEntity.Token_Type, tokenEntity.Access_Token);
                return WebHelper.Post<UserVerListEntity>(paramEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取未读邮件数
        /// </summary>
        /// <param name="tokenEntity">Token实体</param>
        /// <param name="Alias">邮箱账号</param>
        /// <returns></returns>
        public static int MailNewCount(TokenEntity tokenEntity, string Alias)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.MailNewCountUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("Alias", Alias);
                paramEntity.Headers = Utility.GetTokenHeaders(tokenEntity.Token_Type, tokenEntity.Access_Token);
                return WebHelper.Post<MailNewCount>(paramEntity).NewCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取子部门列表
        /// </summary>
        /// <param name="tokenEntity">Token实体</param>
        /// <param name="PartyPath">查看的父亲部门路径。如果查看根部门，置为空。</param>
        /// <returns></returns>
        public static PartyEntity PartyList(TokenEntity tokenEntity, string PartyPath)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.PartyListUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("PartyPath", PartyPath);
                paramEntity.Headers = Utility.GetTokenHeaders(tokenEntity.Token_Type, tokenEntity.Access_Token);
                return WebHelper.Post<PartyEntity>(paramEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取部门下成员列表
        /// </summary>
        /// <param name="tokenEntity">Token实体</param>
        /// <param name="PartyPath">查看的父亲部门路径。如果查看根部门，置为空。</param>
        /// <returns></returns>
        public static PartyUserEntity PartyUserList(TokenEntity tokenEntity, string PartyPath)
        {
            try
            {
                ParamEntity paramEntity = new ParamEntity();
                paramEntity.Url = UrlsConfig.PartyUserListUrl;
                paramEntity.NVCollection = new NameValueCollection();
                paramEntity.NVCollection.Add("PartyPath", PartyPath);
                paramEntity.Headers = Utility.GetTokenHeaders(tokenEntity.Token_Type, tokenEntity.Access_Token);
                return WebHelper.Post<PartyUserEntity>(paramEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
