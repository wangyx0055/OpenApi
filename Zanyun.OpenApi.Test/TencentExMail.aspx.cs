using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZanYun.OpenApi;

namespace ZanYun.OpenApi.Test
{
    public partial class TencentExMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var token = Token();
            var authkey = Authkey(token, "tianwei@ansky.cn");
            //Response.Redirect(Tencent.ExMail.Impl.Login("ansky", "tianwei@ansky.cn", authkey));
            var userInfo = Tencent.ExMail.Impl.UserGet(token, "tianwei@ansky.cn");
            var userVerList = Tencent.ExMail.Impl.UserVerList(token, "0");
            var mailNewCount = Tencent.ExMail.Impl.MailNewCount(token, "tianwei@ansky.cn");
            var partyList = Tencent.ExMail.Impl.PartyList(token, "");
            var partyUserList = Tencent.ExMail.Impl.PartyUserList(token, "");
        }

        private Tencent.ExMail.TokenEntity Token()
        {
            return Tencent.ExMail.Impl.Token("ansky", "e89d8fef0e4814b7638e16cc6d52dedb");
        }

        private string Authkey(Tencent.ExMail.TokenEntity tokenEntity, string alias)
        {
            return Tencent.ExMail.Impl.Authkey(tokenEntity, alias);
        }
    }
}