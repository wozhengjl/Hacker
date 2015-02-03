<%@ WebHandler Language="C#" Class="DoubleColor.Redballs.Handler.OrderHandler" %>

namespace DoubleColor.Redballs.Handler
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using DoubleColor.Redballs.Repository;
    using DoubleColor.Redballs.Common;
    using System.Web.SessionState;

    public class OrderHandler : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpCookie Cookie = CookieHelper.GetCookie("UserInfo");
            if (Cookie != null)
            {
                string userName = Cookie.Values["uName"];
                string password = Cookie.Values["uPwd"];

                var accountRepository = new AccountRepository();
                var account = accountRepository.Read(userName);
                if (account == null)
                {
                    context.Response.Redirect("..\\Logon.html");
                }
                else if (!string.Equals(account.TenantPassword, password))
                {
                    context.Response.Redirect("..\\Logon.html");
                }
            }

            var orderType = context.Request["ordertype"];
            var orderdata = context.Request["orderdata"]; 
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}