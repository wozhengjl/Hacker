namespace DoubleColor.Redballs.Portal
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.Repository;

    public partial class NavigationBar : System.Web.UI.MasterPage
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(Session["IsAuthenticated"]) 
                && Request.FilePath.IndexOf("Logout.aspx") == -1
                && Request.FilePath.IndexOf("Logon.aspx") == -1
                && Request.FilePath.IndexOf("Register.aspx") == -1)
            {
                HttpCookie Cookie = CookieHelper.GetCookie("UserInfo");
                if (Cookie != null)
                {
                    string userName = Cookie.Values["uName"];
                    string password = Cookie.Values["uPwd"];

                    var accountRepository = new AccountRepository();
                    var account = accountRepository.Read(userName);

                    if (account != null && string.Equals(account.TenantPassword, password))
                    {
                        Session[Constants.SessionConstants.IsAuthenticated] = true;
                        Session[Constants.SessionConstants.UName] = userName;
                    }
                }
            }

            HiddenUserName.Value = Session[Constants.SessionConstants.UName] != null ? Session[Constants.SessionConstants.UName].ToString() : "";
        }
    }
}